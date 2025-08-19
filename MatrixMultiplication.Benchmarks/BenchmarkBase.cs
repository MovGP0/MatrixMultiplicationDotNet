using System.Globalization;
using BenchmarkDotNet.Attributes;
using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.Utils;

namespace MatrixMultiplication.Benchmarks;

[MemoryDiagnoser]
[HideColumns("Job", "Error", "StdDev", "RatioSD", "Median", "Gen0", "Gen1", "Gen2")]
[CategoriesColumn]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
public abstract class BenchmarkBase
{
    // Param is a string "n,m,p" so we can feed dynamic data from FormulaLocator.
    [ParamsSource(nameof(Tuples))]
    public string Triple { get; set; } = "2,2,2";

    protected int n, m, p;

    // Inputs reused for all algorithm variants to be fair.
    protected double[,] A_array = default!;
    protected double[,] B_array = default!;
    protected Matrix<double> A_matrix = default!;
    protected Matrix<double> B_matrix = default!;
    protected Formula formula = default!;

    public IEnumerable<string> Tuples()
    {
        // Feed all supported tuples, ordered for stable output.
        foreach (var (tn, tm, tp) in FormulaLocator.GetSupportedTriples())
        {
            yield return $"{tn},{tm},{tp}";
        }
    }

    [GlobalSetup]
    public void Setup()
    {
        var parts = Triple.Split(',');
        n = int.Parse(parts[0], CultureInfo.InvariantCulture);
        m = int.Parse(parts[1], CultureInfo.InvariantCulture);
        p = int.Parse(parts[2], CultureInfo.InvariantCulture);

        // Fixed seed for reproducibility across runs.
        var rng = new Random(42);

        A_array = new double[n, m];
        B_array = new double[m, p];

        // Fill with integers in [-10, 10]
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                A_array[i, j] = rng.Next(-10, 11);

        for (int i = 0; i < m; i++)
            for (int j = 0; j < p; j++)
                B_array[i, j] = rng.Next(-10, 11);

        // Matrix<double> views built from arrays to keep the exact same data.
        A_matrix = Matrix<double>.Build.DenseOfArray(A_array);
        B_matrix = Matrix<double>.Build.DenseOfArray(B_array);

        // Load the factorization for this shape.
        formula = FormulaLocator.BuildFormula(n, m, p);
    }
}