using System.Globalization;
using System.Text.Json;

namespace MatrixMultiplication;

public static class FormulaLoader
{
    public static IEnumerable<Formula> LoadFormulas()
    {
        var directory = Path.Combine(AppContext.BaseDirectory, "Decompositions");
        var shapes = new[]
        {
            (4, 5, 7),
            (4, 6, 6),
            (4, 6, 7),
            (4, 7, 7.1),
            (4, 7, 7.2),
            (5, 5, 6.1),
            (5, 5, 6.2),
            (5, 5, 7.1),
            (5, 5, 7.2),
            (5, 5, 7.3),
            (5, 5, 7.4),
            (5, 5, 7.5),
            (5, 5, 7.6),
            (5, 5, 7.7),
        };

        foreach ((int m, int n, double p) in shapes)
        {
            var fileName = $"{m}{n}{p.ToString("0.#", CultureInfo.InvariantCulture)}.json";
            var filePath = Path.Combine(directory, fileName);
            yield return LoadRealFormulaFromJson(filePath, m, n, (int)p);
        }
    }

    public static Formula LoadRealFormulaFromJson(string jsonPath, int n, int m, int p)
    {
        if (jsonPath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            return LoadRealFormulaFromJson_NonTransposed(jsonPath, n, m, p);

        throw new NotSupportedException($"Unsupported file extension for path: {jsonPath}");
    }

    private static Formula LoadRealFormulaFromJson_NonTransposed(string jsonPath, int n, int m, int p)
    {
        if (string.IsNullOrWhiteSpace(jsonPath))
            throw new ArgumentException("Path is null or empty.", nameof(jsonPath));

        string json = File.ReadAllText(jsonPath);

        // Expected: double[terms][3][rows][cols]
        double[][][][] terms = JsonSerializer.Deserialize<double[][][][]>(json)
            ?? throw new InvalidOperationException("JSON deserialized to null.");

        if (terms.Length == 0)
            throw new InvalidOperationException("No terms found.");

        var result = new ProductTerm[terms.Length];

        for (int t = 0; t < terms.Length; t++)
        {
            var blocks = terms[t] ?? throw new InvalidOperationException($"Term {t}: null.");
            if (blocks.Length != 3)
                throw new InvalidOperationException($"Term {t}: expected 3 blocks (A,B,C).");

            var aJag = blocks[0];
            var bJag = blocks[1];
            var cJag = blocks[2];

            ValidateRectangular(aJag, "A", t);
            ValidateRectangular(bJag, "B", t);
            ValidateRectangular(cJag, "C", t);

            if (aJag.Length != n || aJag[0].Length != m)
                throw new InvalidOperationException($"Term {t} A dims {aJag.Length}x{aJag[0].Length} != {n}x{m}");
            if (bJag.Length != m || bJag[0].Length != p)
                throw new InvalidOperationException($"Term {t} B dims {bJag.Length}x{bJag[0].Length} != {m}x{p}");

            bool cIsNP = cJag.Length == n && cJag[0].Length == p;
            bool cIsPN = cJag.Length == p && cJag[0].Length == n;
            if (!cIsNP && !cIsPN)
                throw new InvalidOperationException(
                    $"Term {t} C dims {cJag.Length}x{cJag[0].Length} is neither {n}x{p} nor {p}x{n}");

            var aArr = new double[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    aArr[i, j] = Norm0(aJag[i][j]);

            var bArr = new double[m, p];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    bArr[i, j] = Norm0(bJag[i][j]);

            var cArr = new double[n, p];
            if (cIsNP)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < p; j++)
                        cArr[i, j] = Norm0(cJag[i][j]);
            }
            else
            {
                // transpose p×n -> n×p
                for (int i = 0; i < p; i++)
                    for (int j = 0; j < n; j++)
                        cArr[j, i] = Norm0(cJag[i][j]);
            }

            result[t] = new ProductTerm(aArr.ToDense(), bArr.ToDense(), cArr.ToDense());
        }

        return new Formula(n, m, p, result);
    }

    private static void ValidateRectangular(double[][] jag, string name, int termIndex)
    {
        if (jag == null || jag.Length == 0 || jag[0] == null)
            throw new InvalidOperationException($"Term {termIndex} {name}: empty or null.");

        int cols = jag[0].Length;
        for (int r = 1; r < jag.Length; r++)
        {
            if (jag[r] == null || jag[r].Length != cols)
                throw new InvalidOperationException(
                    $"Term {termIndex} {name}: jagged row {r}, expected {cols} columns.");
        }
    }

    private static double Norm0(double v) => (v == -0.0) ? 0.0 : v;

    private static Matrix<double> ToDense(this double[,] src)
        => Matrix<double>.Build.DenseOfArray(src);
}