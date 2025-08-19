namespace MatrixMultiplication.Utils;

public static class FormulaCompiler
{
    public static CompiledFormula Compile(Formula f)
    {
        var terms = new List<CompiledTerm>();
        foreach (var t in f.Terms)
        {
            var a = new List<(int,int,double)>();
            var b = new List<(int,int,double)>();
            var c = new List<(int,int,double)>();

            for (int ai = 0; ai < f.N; ai++)
            for (int ak = 0; ak < f.M; ak++)
            {
                double v = t.CoeffsA[ai, ak];
                if (v != 0.0) a.Add((ai, ak, v));
            }

            for (int bk = 0; bk < f.M; bk++)
            for (int bj = 0; bj < f.P; bj++)
            {
                double v = t.CoeffsB[bk, bj];
                if (v != 0.0) b.Add((bk, bj, v));
            }

            for (int ci = 0; ci < f.N; ci++)
            for (int cj = 0; cj < f.P; cj++)
            {
                double v = t.CoeffsC[ci, cj];
                if (v != 0.0) c.Add((ci, cj, v));
            }

            terms.Add(new()
            {
                A = a.ToArray(),
                B = b.ToArray(),
                C = c.ToArray()
            });
        }

        return new(N: f.N, M: f.M, P: f.P, Terms: terms.ToArray());
    }
}