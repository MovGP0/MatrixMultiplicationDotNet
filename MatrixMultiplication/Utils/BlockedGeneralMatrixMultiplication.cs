namespace MatrixMultiplication.Utils;

public static class BlockedGeneralMatrixMultiplication
{
    /// <summary>
    /// Blocked General Matrix Multiplication (GeMM) using AlphaTensor matrix multiplication formulas.
    /// </summary>
    /// <remarks>
    /// Multiplies two large matrices using AlphaTensor formulas with a recursive block strategy.
    /// Falls back to naive multiplication for small bases. 
    /// </remarks>
    public static double[,] MultiplyAlpha(
        double[,] A,
        double[,] B,
        int baseThreshold = 64,
        int idealBlock = 128)
    {
        int nA = A.GetLength(0), mA = A.GetLength(1);
        int nB = B.GetLength(0), pB = B.GetLength(1);
        if (mA != nB) throw new ArgumentException("Inner dimensions must match.");

        var C = new double[nA, pB];
        MultiplyAlphaInto(A, 0, 0, nA, mA, B, 0, 0, nB, pB, C, 0, 0, baseThreshold, idealBlock);
        return C;
    }

    private static void MultiplyAlphaInto(
        double[,] A, int aRow, int aCol, int aRows, int aCols,
        double[,] B, int bRow, int bCol, int bRows, int bCols,
        double[,] C, int cRow, int cCol,
        int baseThreshold,
        int idealBlock,
        bool compile = false)
    {
        // Base case: use naive if small
        if (aRows <= baseThreshold || aCols <= baseThreshold || bCols <= baseThreshold)
        {
            NaiveInto(A, aRow, aCol, aRows, aCols,
                      B, bRow, bCol, bRows, bCols,
                      C, cRow, cCol, add: true);
            return;
        }

        int N = aRows, M = aCols, P = bCols;

        // Choose an AlphaTensor triple greedily by efficiency (R / (n*p)) and fit to current sizes.
        var triple = ChooseBestTriple(N, M, P);

        if (triple == null)
        {
            // No triple fits: fallback to naive
            NaiveInto(A, aRow, aCol, aRows, aCols,
                      B, bRow, bCol, bRows, bCols,
                      C, cRow, cCol, add: true);
            return;
        }

        var (n, m, p) = triple.Value;
        var formula = Utils.FormulaLocator.BuildFormula(n, m, p);

        // Pick block sizes (physical submatrix sizes) for this tile.
        // We cover as large a tile as possible while keeping block shapes balanced.
        int br = Math.Max(1, Math.Min(idealBlock, N / n));
        int bp = Math.Max(1, Math.Min(idealBlock, P / p));

        for (int i0 = 0; i0 < N; )
        {
            int rowsLeft = N - i0;
            int thisBr = Math.Min(br, rowsLeft / n);
            if (thisBr == 0) thisBr = rowsLeft / n; // try to fill exactly if br too large
            if (thisBr == 0) { // still zero => remaining rows smaller than n => shrink n via fallback
                NaiveInto(A, aRow + i0, aCol, rowsLeft, M,
                          B, bRow, bCol, bRows, bCols,
                          C, cRow + i0, cCol, add: true);
                break;
            }
            int tileRows = thisBr * n;

            for (int j0 = 0; j0 < P; )
            {
                int colsLeft = P - j0;
                int thisBp = Math.Min(bp, colsLeft / p);
                if (thisBp == 0) thisBp = colsLeft / p;
                if (thisBp == 0) {
                    // remaining cols smaller than p => fallback
                    NaiveInto(A, aRow + i0, aCol, tileRows, M,
                              B, bRow, bCol + j0, bRows, colsLeft,
                              C, cRow + i0, cCol + j0, add: true);
                    break;
                }
                int tileCols = thisBp * p;

                // Zero tile of C to accumulate across K-tiles
                ZeroInto(C, cRow + i0, cCol + j0, tileRows, tileCols);

                for (int k0 = 0; k0 < M;)
                {
                    int kLeft = M - k0;
                    int bc = Math.Max(1, Math.Min(idealBlock, kLeft / m));
                    if (bc == 0) bc = kLeft / m;
                    if (bc == 0)
                    {
                        // remaining k smaller than m => fallback and add-assign into C-tile
                        var tmp = new double[tileRows, tileCols];
                        NaiveInto(A, aRow + i0, aCol + k0, tileRows, kLeft,
                            B, bRow + k0, bCol + j0, kLeft, tileCols,
                            tmp, 0, 0, add: true);
                        AddAssign(C, cRow + i0, cCol + j0, tmp, 0, 0, tileRows, tileCols, 1.0);
                        break;
                    }

                    int tileK = bc * m;

                    // Compute tile C += (A(i0:i0+tileRows, k0:k0+tileK)) x (B(k0:k0+tileK, j0:j0+tileCols))
                    if (compile)
                    {
                        var compiled = FormulaCompiler.Compile(formula); // TODO: cache the compiled formula
                        MultiplyTileUsingCompiledFormula(
                            A, aRow + i0, aCol + k0, thisBr, bc,
                            B, bRow + k0, bCol + j0, bc, thisBp,
                            C, cRow + i0, cCol + j0,
                            compiled, baseThreshold, idealBlock);
                    }
                    else
                    {
                        MultiplyTileUsingFormula(
                            A, aRow + i0, aCol + k0, thisBr, bc, // A block size: br x bc
                            B, bRow + k0, bCol + j0, bc, thisBp, // B block size: bc x bp
                            C, cRow + i0, cCol + j0, // C tile origin
                            formula, baseThreshold, idealBlock);
                    }

                    k0 += tileK;
                }

                j0 += tileCols;
            }

            i0 += tileRows;
        }
    }

    /// <summary>
    /// Apply one AlphaTensor formula to block-tiles:
    /// A is partitioned into n x m blocks, each of size (br x bc).
    /// B is partitioned into m x p blocks, each of size (bc x bp).
    /// C is partitioned into n x p blocks, each of size (br x bp) and incremented by the product.
    /// </summary>
    /// <summary>
    /// Applies <paramref name="formula"/> to a tile triple:
    /// A is partitioned into n×m blocks of size (br×bc),
    /// B into m×p blocks of size (bc×bp),
    /// C into n×p blocks of size (br×bp).
    /// </summary>
    private static void MultiplyTileUsingFormula(
        double[,] A, int aRow, int aCol, int br, int bc,          // A block size
        double[,] B, int bRow, int bCol, int bc2, int bp,         // B block size
        double[,] C, int cRow, int cCol,                          // C tile origin
        Formula formula,                                          // term-based
        int baseThreshold, int idealBlock)
    {
        if (bc != bc2)
            throw new ArgumentException("Block K sizes must match (bc).");

        int n = formula.N, m = formula.M, p = formula.P;

        // temporaries reused across terms
        var SA = new double[br, bc];
        var SB = new double[bc, bp];

        foreach (var term in formula.Terms)
        {
            // SA = sum_{ai,ak} CoeffsA[ai,ak] * A_block(ai,ak)
            ZeroInto(SA, 0, 0, br, bc);
            for (int ai = 0; ai < n; ai++)
            {
                int srcRow = aRow + ai * br;
                for (int ak = 0; ak < m; ak++)
                {
                    double coeff = term.CoeffsA[ai, ak];
                    if (coeff == 0.0) continue;

                    int srcCol = aCol + ak * bc;
                    ScaleAddAssign(SA, 0, 0, A, srcRow, srcCol, br, bc, coeff);
                }
            }

            // SB = sum_{bk,bj} CoeffsB[bk,bj] * B_block(bk,bj)
            ZeroInto(SB, 0, 0, bc, bp);
            for (int bk = 0; bk < m; bk++)
            {
                int srcRow = bRow + bk * bc;
                for (int bj = 0; bj < p; bj++)
                {
                    double coeff = term.CoeffsB[bk, bj];
                    if (coeff == 0.0) continue;

                    int srcCol = bCol + bj * bp;
                    ScaleAddAssign(SB, 0, 0, B, srcRow, srcCol, bc, bp, coeff);
                }
            }

            // TR = SA × SB (recurse with the same blocked strategy)
            var TR = MultiplyAlpha(SA, SB, baseThreshold, idealBlock); // (br×bp)

            // C += sum_{ci,cj} CoeffsC[ci,cj] * TR into block(ci,cj)
            for (int ci = 0; ci < n; ci++)
            {
                int dstRow = cRow + ci * br;
                for (int cj = 0; cj < p; cj++)
                {
                    double coeff = term.CoeffsC[ci, cj];
                    if (coeff == 0.0) continue;

                    int dstCol = cCol + cj * bp;
                    ScaleAddAssign(C, dstRow, dstCol, TR, 0, 0, br, bp, coeff);
                }
            }
        }
    }

    private static void MultiplyTileUsingCompiledFormula(
        double[,] A, int aRow, int aCol, int br, int bc,
        double[,] B, int bRow, int bCol, int bc2, int bp,
        double[,] C, int cRow, int cCol,
        CompiledFormula cf,
        int baseThreshold,
        int idealBlock)
    {
        if (bc != bc2) throw new ArgumentException("Block K sizes must match (bc).");
        int n = cf.N, m = cf.M, p = cf.P;

        var SA = new double[br, bc];
        var SB = new double[bc, bp];

        foreach (var term in cf.Terms)
        {
            ZeroInto(SA, 0, 0, br, bc);
            foreach (var (ai, ak, coeff) in term.A)
                ScaleAddAssign(SA, 0, 0, A, aRow + ai * br, aCol + ak * bc, br, bc, coeff);

            ZeroInto(SB, 0, 0, bc, bp);
            foreach (var (bk, bj, coeff) in term.B)
                ScaleAddAssign(SB, 0, 0, B, bRow + bk * bc, bCol + bj * bp, bc, bp, coeff);

            var TR = MultiplyAlpha(SA, SB, baseThreshold, idealBlock);

            foreach (var (ci, cj, coeff) in term.C)
                ScaleAddAssign(C, cRow + ci * br, cCol + cj * bp, TR, 0, 0, br, bp, coeff);
        }
    }

    private static void ZeroInto(double[,] M, int r0, int c0, int rows, int cols)
    {
        for (int i=0;i<rows;i++)
            for (int j=0;j<cols;j++)
                M[r0 + i, c0 + j] = 0.0;
    }

    private static void AddAssign(double[,] D, int dr, int dc, double[,] S, int sr, int sc, int rows, int cols, double alpha)
    {
        for (int i=0;i<rows;i++)
            for (int j=0;j<cols;j++)
                D[dr + i, dc + j] += alpha * S[sr + i, sc + j];
    }

    private static void ScaleAddAssign(double[,] D, int dr, int dc, double[,] S, int sr, int sc, int rows, int cols, double alpha)
    {
        for (int i=0;i<rows;i++)
            for (int j=0;j<cols;j++)
                D[dr + i, dc + j] += alpha * S[sr + i, sc + j];
    }

    private static void NaiveInto(
        double[,] A, int aRow, int aCol, int aRows, int aCols,
        double[,] B, int bRow, int bCol, int bRows, int bCols,
        double[,] C, int cRow, int cCol, bool add)
    {
        if (!add) ZeroInto(C, cRow, cCol, aRows, bCols);
        for (int i=0;i<aRows;i++)
        {
            for (int k=0;k<aCols;k++)
            {
                double aik = A[aRow + i, aCol + k];
                double[] bRowPtr = GetRow(B, bRow + k, bCol, bCols);
                for (int j=0;j<bCols;j++)
                {
                    C[cRow + i, cCol + j] += aik * bRowPtr[j];
                }
            }
        }
    }

    /// <summary>
    /// Returns a copy of a row segment (to improve cache locality a bit)
    /// </summary>
    private static double[] GetRow(double[,] M, int r, int c0, int len)
    {
        var tmp = new double[len];
        for (int j=0;j<len;j++) tmp[j] = M[r, c0 + j];
        return tmp;
    }

    private static (int n,int m,int p)? ChooseBestTriple(int N, int M, int P)
    {
        // Filter by fit, then sort by efficiency = R / (n*p), then by coverage (n*p) descending
        var candidates = Utils.FormulaLocator.RealMetas
            .Where(t => t.n <= N && t.m <= M && t.p <= P)
            .OrderBy(t => (double)t.R / (t.n * t.p))
            .ThenByDescending(t => t.n * t.p)
            .ToArray();

        if (candidates.Length == 0) return null;

        var best = candidates[0];
        return (best.n, best.m, best.p);
    }
}
