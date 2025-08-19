namespace MatrixMultiplication.Utils;

public static class FormulaBuilder
{
    internal static Formula BuildFormulaFromUVW(
        int n,
        int m,
        int p,
        double[,] U,
        double[,] V,
        double[,] W
    )
    {
        if (U == null || V == null || W == null)
        {
            throw new ArgumentNullException("U/V/W must be non-null.");
        }

        int Ru = n * m;
        int Rv = m * p;
        int Rw = n * p;

        // Figure out term count T and validate R per block
        int Tu = GetTermCountAndValidate(U, Ru, "U");
        int Tv = GetTermCountAndValidate(V, Rv, "V");
        int Tw = GetTermCountAndValidate(W, Rw, "W");

        if (Tu != Tv || Tu != Tw)
            throw new ArgumentException($"Term counts differ: U={Tu}, V={Tv}, W={Tw}.");

        int T = Tu;
        var terms = new ProductTerm[T];

        for (int ti = 0; ti < T; ti++)
        {
            int t = ti;

            var A = new double[n, m];
            var B = new double[m, p];
            var C = new double[n, p];

            // Copy a vector (length R) for term t from each block, then reshape
            var uvec = ExtractVector(U, Ru, t);
            var vvec = ExtractVector(V, Rv, t);
            var wvec = ExtractVector(W, Rw, t);

            // reshape vectors into matrices
            FillMatrixFromVector(A, uvec, FlatteningOrder.RowMajor);
            FillMatrixFromVector(B, vvec, FlatteningOrder.RowMajor);
            FillMatrixFromVector(C, wvec, FlatteningOrder.ColumnMajor);

            terms[ti] = new ProductTerm(
                Matrix<double>.Build.DenseOfArray(A),
                Matrix<double>.Build.DenseOfArray(B),
                Matrix<double>.Build.DenseOfArray(C));
        }

        return new Formula(n, m, p, terms);
    }

    private static int GetTermCountAndValidate(double[,] M, int R, string name)
    {
        int r0 = M.GetLength(0), r1 = M.GetLength(1);

        // shape R × T
        if (r0 != R)
            throw new ArgumentException($"{name}: expected rows == {R} (R×T). Got {r0}×{r1}.");
        return r1; // T
    }

    private static double[] ExtractVector(double[,] block, int R, int t)
    {
        var vec = new double[R];

        // (R × T): row is flattened coord, col is term
        for (int r = 0; r < R; r++)
        {
            double v = block[r, t];
            vec[r] = (v == -0.0) ? 0.0 : v;
        }

        return vec;
    }

    private static void FillMatrixFromVector(double[,] dst, double[] vec, FlatteningOrder order)
    {
        int rows = dst.GetLength(0);
        int cols = dst.GetLength(1);
        if (vec.Length != rows * cols)
            throw new ArgumentException("Vector length does not match matrix shape.");

        for (int r = 0; r < vec.Length; r++)
        {
            int i, j;
            if (order == FlatteningOrder.RowMajor)
            {
                i = r / cols;
                j = r % cols;
            }
            else // ColumnMajor
            {
                i = r % rows;
                j = r / rows;
            }
            dst[i, j] = vec[r];
        }
    }

    private enum FlatteningOrder
    {
        ColumnMajor, // r = i + rows * j
        RowMajor     // r = i * cols + j
    }
}