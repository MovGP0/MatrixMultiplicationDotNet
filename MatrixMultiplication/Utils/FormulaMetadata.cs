using MatrixMultiplication.KnownAlgorithms;

namespace MatrixMultiplication.Utils;

public static class FormulaMetadata
{
    internal static readonly AlgoMeta[] RealMetas =
    [
        new(2, 2, 2, 7, 14, 14, 12),
        new(2, 2, 3, 11, 17, 19, 17),
        new(2, 2, 4, 14, 26, 31, 27),
        new(2, 2, 5, 18, 34, 35, 42),
        new(2, 2, 6, 21, 36, 36, 36),
        new(2, 2, 7, 25, 42, 52, 45),
        new(2, 2, 8, 28, 56, 63, 56),
        new(2, 3, 3, 15, 32, 30, 32),
        new(2, 3, 4, 20, 42, 54, 40),
        new(2, 3, 5, 25, 60, 62, 51),
        new(2, 4, 4, 26, 59, 64, 59),
        new(2, 4, 5, 33, 102, 97, 77),
        new(2, 5, 5, 40, 131, 128, 114),
        new(3, 3, 3, 23, 59, 53, 53),
        new(3, 3, 4, 29, 68, 75, 75),
        new(3, 3, 5, 36, 87, 104, 81),
        new(3, 4, 4, 38, 96, 101, 95),
        new(3, 4, 5, 47, 144, 130, 128),
        new(3, 4, 11, 103, 307, 365, 275),
        new(3, 5, 5, 58, 164, 176, 160),
        new(3, 5, 9, 105, 292, 306, 304),
        new(3, 9, 11, 225, 880, 1458, 1444),
        new(4, 4, 4, 49, 194, 194, 194),
        new(4, 4, 5, 63, 215, 233, 171),
        new(4, 5, 5, 76, 251, 270, 200),
        new(4, 5, 9, 139, 422, 503, 415),
        new(4, 5, 10, 152, 502, 810, 600),
        new(4, 5, 11, 169, 516, 576, 516),
        new(4, 9, 10, 255, 1164, 1356, 1134),
        new(4, 9, 11, 280, 1254, 1688, 1230),
        new(4, 11, 11, 343, 1515, 1980, 1661),
        new(4, 11, 12, 366, 1650, 2140, 1854),
        new(5, 5, 5, 98, 293, 299, 272),
        new(5, 5, 7, 134, 446, 360, 415),
        new(5, 7, 9, 234, 1118, 1117, 891),
        new(5, 7, 10, 257, 1271, 1337, 1004),
        new(5, 7, 11, 280, 1765, 2801, 2223),
        new(5, 8, 9, 262, 1408, 1337, 1027),
        new(5, 8, 10, 287, 1590, 1589, 1197),
        new(5, 8, 11, 317, 1746, 2146, 1300),
        new(5, 9, 9, 296, 1565, 1567, 1272),
        new(5, 9, 10, 323, 1757, 1802, 1418),
        new(5, 9, 11, 358, 1606, 2100, 1720),
        new(5, 9, 12, 381, 1689, 2406, 1932),
        new(6, 7, 9, 270, 1107, 1458, 1372),
        new(6, 7, 10, 296, 1602, 1574, 1301),
        new(6, 7, 11, 322, 2208, 2962, 2203),
        new(6, 8, 10, 329, 2016, 1820, 1536),
        new(6, 8, 11, 365, 2206, 2536, 1631),
        new(6, 9, 9, 342, 1964, 1779, 1592),
        new(6, 9, 10, 373, 2120, 2086, 1760),
        new(6, 9, 11, 411, 2095, 2402, 2278),
        new(7, 7, 9, 318, 1855, 1790, 1434),
        new(7, 7, 10, 350, 2020, 2030, 1526),
        new(7, 7, 11, 384, 2168, 2591, 2258),
        new(7, 8, 9, 354, 1612, 2067, 1728),
        new(7, 8, 10, 393, 2499, 2438, 1991),
        new(7, 8, 11, 432, 2031, 2515, 2267),
        new(7, 8, 12, 462, 2208, 2583, 2428),
        new(7, 9, 9, 399, 2096, 2238, 2061),
        new(7, 9, 10, 441, 2360, 2570, 1876),
        new(7, 9, 11, 481, 3644, 6540, 4698),
        new(7, 9, 12, 510, 3840, 5604, 5376),
        new(7, 10, 10, 478, 2864, 2770, 2400),
        new(7, 10, 11, 536, 3335, 3666, 4104),
        new(7, 11, 11, 582, 4548, 4800, 4742),
        new(8, 8, 10, 441, 3010, 3262, 2394),
        new(8, 8, 11, 489, 2397, 2634, 2816),
        new(8, 9, 10, 489, 2694, 2700, 2752),
        new(8, 9, 11, 533, 4683, 8316, 6984),
        new(8, 9, 12, 560, 5504, 10464, 8576),
        new(8, 10, 10, 532, 3514, 3240, 2800),
        new(8, 10, 11, 596, 3635, 3882, 4267),
        new(8, 10, 12, 636, 4040, 4572, 4457),
        new(8, 11, 11, 649, 4471, 4915, 4960),
        new(8, 11, 12, 691, 5020, 5868, 5852),
        new(9, 9, 9, 498, 7044, 4966, 7356),
        new(9, 9, 10, 534, 5176, 8196, 7684),
        new(9, 9, 11, 576, 5442, 9120, 8204),
        new(9, 10, 10, 606, 3250, 3524, 3150),
        new(9, 10, 11, 657, 4417, 7620, 7009),
        new(9, 10, 12, 696, 6248, 10676, 8970),
        new(9, 11, 11, 725, 10337, 8370, 6822),
        new(9, 11, 12, 760, 8448, 11072, 14184),
        new(10, 10, 10, 682, 3662, 4386, 4278),
        new(10, 10, 11, 746, 5251, 7443, 6655),
        new(10, 10, 12, 798, 5728, 8899, 7816),
        new(10, 11, 11, 821, 4864, 5200, 5702),
        new(10, 11, 12, 874, 7659, 8722, 11354),
        new(10, 12, 12, 928, 13054, 10506, 8772),
        new(11, 11, 11, 896, 13206, 9097, 13110),
        new(11, 11, 12, 941, 10180, 15456, 15876),
        new(11, 12, 12, 990, 19200, 18768, 12288),
        Decomposition_4x5x7.Build4x5x7Metadata(),
        Decomposition_4x6x6.Build4x6x6Metadata(),
        Decomposition_4x6x7.Build4x6x7Metadata(),
        Decomposition_4x7x7.Build4x7x7Metadata(),
        Decomposition_5x5x6.Build5x5x6Metadata()
    ];

    /// <summary>
    /// Count predicate for real values (treats ±0 as zero; optional tolerance).
    /// </summary>
    private static bool IsNonZero(double x, double eps) =>
        !double.IsNaN(x) && !double.IsInfinity(x) && Math.Abs(x) > eps;

    /// <summary>
    /// Count predicate for complex values (magnitude with optional tolerance).
    /// </summary>
    private static bool IsNonZero(System.Numerics.Complex z, double eps) =>
        !double.IsNaN(z.Real) && !double.IsNaN(z.Imaginary) &&
        !double.IsInfinity(z.Real) && !double.IsInfinity(z.Imaginary) &&
        z.Magnitude > eps;

    /// <summary>
    /// From a dense real-valued Formula (ProductTerm).
    /// </summary>
    public static AlgoMeta FromFormula(Formula f, double eps = 0.0)
    {
        // n, m, p
        int n = f.N, m = f.M, p = f.P;

        int r = 0, nnzU = 0, nnzV = 0, nnzW = 0;

        foreach (var t in f.Terms)
        {
            r++;

            // A is n×m, B is m×p, C is n×p
            var a = t.CoeffsA;
            var b = t.CoeffsB;
            var c = t.CoeffsC;

            // Count non-zeros with optional tolerance
            nnzU += CountNonZeros(a, eps);
            nnzV += CountNonZeros(b, eps);
            nnzW += CountNonZeros(c, eps);
        }

        return new AlgoMeta(n, m, p, r, nnzU, nnzV, nnzW);
    }

    /// <summary>
    /// From a dense complex-valued ComplexFormula (ComplexProductTerm).
    /// </summary>
    public static AlgoMeta FromComplexFormula(ComplexFormula f, double eps = 0.0)
    {
        int n = f.N, m = f.M, p = f.P;

        int r = 0, nnzU = 0, nnzV = 0, nnzW = 0;

        foreach (var t in f.Terms)
        {
            r++;

            nnzU += CountNonZeros(t.CoeffsA, eps);
            nnzV += CountNonZeros(t.CoeffsB, eps);
            nnzW += CountNonZeros(t.CoeffsC, eps);
        }

        return new AlgoMeta(n, m, p, r, nnzU, nnzV, nnzW);
    }

    /// <summary>
    /// From a compiled (sparse) representation. Arrays are assumed to list only non-zeros,
    /// but we still filter by tolerance to be robust.
    /// </summary>
    public static AlgoMeta FromCompiled(CompiledFormula cf, double eps = 0.0)
    {
        int n = cf.N, m = cf.M, p = cf.P;

        int r = cf.Terms?.Length ?? 0;
        int nnzU = 0, nnzV = 0, nnzW = 0;

        if (cf.Terms != null)
        {
            foreach (var t in cf.Terms)
            {
                if (t?.A != null) nnzU += CountNonZeros(t.A, eps);
                if (t?.B != null) nnzV += CountNonZeros(t.B, eps);
                if (t?.C != null) nnzW += CountNonZeros(t.C, eps);
            }
        }

        return new AlgoMeta(n, m, p, r, nnzU, nnzV, nnzW);
    }

    private static int CountNonZeros(Matrix<double> M, double eps)
    {
        int cnt = 0;
        for (int i = 0; i < M.RowCount; i++)
        for (int j = 0; j < M.ColumnCount; j++)
        {
            if (IsNonZero(M[i, j], eps))
            {
                cnt++;
            }
        }
        return cnt;
    }

    private static int CountNonZeros(Matrix<System.Numerics.Complex> M, double eps)
    {
        int cnt = 0;
        for (int i = 0; i < M.RowCount; i++)
        for (int j = 0; j < M.ColumnCount; j++)
        {
            if (IsNonZero(M[i, j], eps))
            {
                cnt++;
            }
        }
        return cnt;
    }

    private static int CountNonZeros((int a, int b, double c)[] entries, double eps)
    {
        int cnt = 0;
        for (int k = 0; k < entries.Length; k++)
        {
            if (IsNonZero(entries[k].c, eps))
            {
                cnt++;
            }
        }
        return cnt;
    }
}