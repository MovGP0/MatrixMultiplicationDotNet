namespace MatrixMultiplication.KnownAlgorithms;

public static class Laderman_3x3x3
{
    /// <summary>
    /// Laderman’s 3×3 (23 products), exactly as in mat_mult_laderman.m.
    /// u=0, v=1, w=2 are row/col indices.
    /// </summary>
    public static Formula BuildLaderman3x3Formula()
    {
        int n = 3, m = 3, p = 3;
        int u = 0, v = 1, w = 2;

        static Matrix<double> Mask(int rows, int cols, params (int r, int c, double v)[] entries)
        {
            var M = Matrix<double>.Build.Dense(rows, cols, 0.0);
            foreach (var (r, c, v) in entries) M[r, c] += v;
            return M;
        }

        // Record which C entries each M_k contributes to (all +1 per reference)
        var Cspots = new[]
        {
            // 1-based for readability in comment; code uses 0-based
            // C11: M6,M14,M19
            new[] { (1,1,6), (1,1,14), (1,1,19) },

            // C12: M1,M4,M5,M6,M12,M14,M15
            new[] { (1,2,1), (1,2,4), (1,2,5), (1,2,6), (1,2,12), (1,2,14), (1,2,15) },

            // C13: M6,M7,M9,M10,M14,M16,M18
            new[] { (1,3,6), (1,3,7), (1,3,9), (1,3,10), (1,3,14), (1,3,16), (1,3,18) },

            // C21: M2,M3,M4,M6,M14,M16,M17
            new[] { (2,1,2), (2,1,3), (2,1,4), (2,1,6), (2,1,14), (2,1,16), (2,1,17) },

            // C22: M2,M4,M5,M6,M20
            new[] { (2,2,2), (2,2,4), (2,2,5), (2,2,6), (2,2,20) },

            // C23: M14,M16,M17,M18,M21
            new[] { (2,3,14), (2,3,16), (2,3,17), (2,3,18), (2,3,21) },

            // C31: M6,M7,M8,M11,M12,M13,M14
            new[] { (3,1,6), (3,1,7), (3,1,8), (3,1,11), (3,1,12), (3,1,13), (3,1,14) },

            // C32: M12,M13,M14,M15,M22
            new[] { (3,2,12), (3,2,13), (3,2,14), (3,2,15), (3,2,22) },

            // C33: M6,M7,M8,M9,M23
            new[] { (3,3,6), (3,3,7), (3,3,8), (3,3,9), (3,3,23) },
        };

        // Build C masks for each term, initially zero, then mark the placements above.
        var Cmask = new Matrix<double>[24]; // 1..23 used
        for (int k = 1; k <= 23; k++) Cmask[k] = Matrix<double>.Build.Dense(n, p, 0.0);
        foreach (var group in Cspots)
        {
            foreach (var (ri, cj, mk) in group)
            {
                Cmask[mk][ri - 1, cj - 1] += 1.0;
            }
        }

        var terms = new ProductTerm[23];

        // M1
        terms[0] = new ProductTerm(
            Mask(3,3,
                (u,u,+1),(u,v,+1),(u,w,+1),
                (v,u,-1),(v,v,-1),
                (w,v,-1),(w,w,-1)),
            Mask(3,3,(v,v,+1)),
            Cmask[1]);

        // M2
        terms[1] = new ProductTerm(
            Mask(3,3,(u,u,+1),(v,u,-1)),
            Mask(3,3,(u,v,-1),(v,v,+1)),
            Cmask[2]);

        // M3
        terms[2] = new ProductTerm(
            Mask(3,3,(v,v,+1)),
            Mask(3,3,(u,u,-1),(u,v,+1),(v,u,+1),(v,v,-1),(v,w,-1),(w,u,-1),(w,w,+1)),
            Cmask[3]);

        // M4
        terms[3] = new ProductTerm(
            Mask(3,3,(u,u,-1),(v,u,+1),(v,v,+1)),
            Mask(3,3,(u,u,+1),(u,v,-1),(v,v,+1)),
            Cmask[4]);

        // M5
        terms[4] = new ProductTerm(
            Mask(3,3,(v,u,+1),(v,v,+1)),
            Mask(3,3,(u,u,-1),(u,v,+1)),
            Cmask[5]);

        // M6
        terms[5] = new ProductTerm(
            Mask(3,3,(u,u,+1)),
            Mask(3,3,(u,u,+1)),
            Cmask[6]);

        // M7
        terms[6] = new ProductTerm(
            Mask(3,3,(u,u,-1),(w,u,+1),(w,v,+1)),
            Mask(3,3,(u,u,+1),(u,w,-1),(v,w,+1)),
            Cmask[7]);

        // M8
        terms[7] = new ProductTerm(
            Mask(3,3,(u,u,-1),(w,u,+1)),
            Mask(3,3,(u,w,+1),(v,w,-1)),
            Cmask[8]);

        // M9
        terms[8] = new ProductTerm(
            Mask(3,3,(w,u,+1),(w,v,+1)),
            Mask(3,3,(u,u,-1),(u,w,+1)),
            Cmask[9]);

        // M10
        terms[9] = new ProductTerm(
            Mask(3,3,
                (u,u,+1),(u,v,+1),(u,w,+1),
                (v,v,-1),(v,w,-1),
                (w,u,-1),(w,v,-1)),
            Mask(3,3,(v,w,+1)),
            Cmask[10]);

        // M11
        terms[10] = new ProductTerm(
            Mask(3,3,(w,v,+1)),
            Mask(3,3,(u,u,-1),(u,w,+1),(v,u,+1),(v,v,-1),(v,w,-1),(w,u,-1),(w,v,+1)),
            Cmask[11]);

        // M12
        terms[11] = new ProductTerm(
            Mask(3,3,(u,w,-1),(w,v,+1),(w,w,+1)),
            Mask(3,3,(v,v,+1),(w,u,+1),(w,v,-1)),
            Cmask[12]);

        // M13
        terms[12] = new ProductTerm(
            Mask(3,3,(u,w,+1),(w,w,-1)),
            Mask(3,3,(v,v,+1),(w,v,-1)),
            Cmask[13]);

        // M14
        terms[13] = new ProductTerm(
            Mask(3,3,(u,w,+1)),
            Mask(3,3,(w,u,+1)),
            Cmask[14]);

        // M15
        terms[14] = new ProductTerm(
            Mask(3,3,(w,v,+1),(w,w,+1)),
            Mask(3,3,(w,u,-1),(w,v,+1)),
            Cmask[15]);

        // M16
        terms[15] = new ProductTerm(
            Mask(3,3,(u,w,-1),(v,v,+1),(v,w,+1)),
            Mask(3,3,(v,w,+1),(w,u,+1),(w,w,-1)),
            Cmask[16]);

        // M17
        terms[16] = new ProductTerm(
            Mask(3,3,(u,w,+1),(v,w,-1)),
            Mask(3,3,(v,w,+1),(w,w,-1)),
            Cmask[17]);

        // M18
        terms[17] = new ProductTerm(
            Mask(3,3,(v,v,+1),(v,w,+1)),
            Mask(3,3,(w,u,-1),(w,w,+1)),
            Cmask[18]);

        // M19
        terms[18] = new ProductTerm(
            Mask(3,3,(u,v,+1)),
            Mask(3,3,(v,u,+1)),
            Cmask[19]);

        // M20
        terms[19] = new ProductTerm(
            Mask(3,3,(v,w,+1)),
            Mask(3,3,(w,v,+1)),
            Cmask[20]);

        // M21
        terms[20] = new ProductTerm(
            Mask(3,3,(v,u,+1)),
            Mask(3,3,(u,w,+1)),
            Cmask[21]);

        // M22
        terms[21] = new ProductTerm(
            Mask(3,3,(w,u,+1)),
            Mask(3,3,(u,v,+1)),
            Cmask[22]);

        // M23
        terms[22] = new ProductTerm(
            Mask(3,3,(w,w,+1)),
            Mask(3,3,(w,w,+1)),
            Cmask[23]);

        return new Formula(n, m, p, terms);
    }
}