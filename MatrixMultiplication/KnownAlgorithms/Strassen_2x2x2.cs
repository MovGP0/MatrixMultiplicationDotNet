namespace MatrixMultiplication.KnownAlgorithms;

public static class Strassen_2x2x2
{
    /// <summary>
    /// Strassen base-case for 2x2 × 2x2 (7 products).
    /// A, B, C in each ProductTerm are 2x2 coefficient matrices.
    /// </summary>
    public static Formula BuildStrassen2x2Formula()
    {
        int n = 2, m = 2, p = 2;
        var terms = new List<ProductTerm>(7);

        // helpers
        static Matrix<double> M2(
            double a00, double a01,
            double a10, double a11)
        {
            var arr = new[,]
            {
                { a00, a01 },
                { a10, a11 }
            };
            return Matrix<double>.Build.DenseOfArray(arr);
        }

        void Add(Matrix<double> a, Matrix<double> b, Matrix<double> c)
            => terms.Add(new ProductTerm(a, b, c));

        // Strassen products (M1..M7), and their placement (C matrices)
        // M1 = (A11 + A22) * (B11 + B22)
        Add(
            M2(1,0, 0,1),
            M2(1,0, 0,1),
            // contributes to C11 and C22
            M2(1,0, 0,1)
        );

        // M2 = (A21 + A22) * B11
        Add(
            M2(0,0, 1,1),
            M2(1,0, 0,0),
            // C21 +1, C22 -1
            M2(0,0, 1,-1)
        );

        // M3 = A11 * (B12 - B22)
        Add(
            M2(1,0, 0,0),
            M2(0,1, 0,-1),
            // C12 +1, C22 +1
            M2(0,1, 0,1)
        );

        // M4 = A22 * (B21 - B11)
        Add(
            M2(0,0, 0,1),
            M2(-1,0, 1,0),
            // C11 +1, C21 +1
            M2(1,0, 1,0)
        );

        // M5 = (A11 + A12) * B22
        Add(
            M2(1,1, 0,0),
            M2(0,0, 0,1),
            // C11 -1, C12 +1
            M2(-1,1, 0,0)
        );

        // M6 = (A21 - A11) * (B11 + B12)
        Add(
            M2(-1,0, 1,0),
            M2(1,1, 0,0),
            // C22 +1
            M2(0,0, 0,1)
        );

        // M7 = (A12 - A22) * (B21 + B22)
        Add(
            M2(0,1, 0,-1),
            M2(0,0, 1,1),
            // C11 +1
            M2(1,0, 0,0)
        );

        return new(n, m, p, terms.ToArray());
    }
}