using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.Utils;

namespace MatrixMultiplication.Tests.Utils;

public class BlockedGeneralMatrixMultiplicationTests
{
    private static readonly Random Rng = new(123456); // deterministic

    private static double[,] ToArray2D(Matrix<double> M)
    {
        int r = M.RowCount, c = M.ColumnCount;
        var a = new double[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                a[i, j] = M[i, j];
        return a;
    }

    private static Matrix<double> FromArray2D(double[,] A)
        => Matrix<double>.Build.DenseOfArray(A);

    private static void AssertMatrixAlmostEqual(Matrix<double> expected, Matrix<double> actual, double tol = 0.0)
    {
        Assert.Equal(expected.RowCount, actual.RowCount);
        Assert.Equal(expected.ColumnCount, actual.ColumnCount);
        for (int i = 0; i < expected.RowCount; i++)
            for (int j = 0; j < expected.ColumnCount; j++)
                Assert.InRange(Math.Abs(expected[i, j] - actual[i, j]), 0.0, tol);
    }

    private static Matrix<double> RandomIntMatrix(int rows, int cols, int min = -10, int max = 10)
    {
        var M = Matrix<double>.Build.Dense(rows, cols);
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                M[r, c] = Rng.Next(min, max + 1);
        return M;
    }

    /// <summary>
    /// Generate ~40 random (n,m,p) triples with sizes in [1..20]
    /// </summary>
    public static IEnumerable<object[]> RandomSizeTriples()
    {
        var seen = new HashSet<(int,int,int)>();
        for (int k = 0; k < 40; k++)
        {
            int n = Rng.Next(1, 21);
            int m = Rng.Next(1, 21);
            int p = Rng.Next(1, 21);
            if (!seen.Add((n, m, p))) { k--; continue; }
            yield return [n, m, p];
        }
    }

    /// <summary>
    /// A few threshold/block configurations to vary recursion paths
    /// </summary>
    public static IEnumerable<object[]> PlannerConfigs()
    {
        yield return new object[] { 32,  96 };
        yield return new object[] { 64, 128 };
        yield return new object[] { 96, 192 };
    }

    [Theory]
    [MemberData(nameof(RandomSizeTriples))]
    public void MultiplyAlpha_MatchesNaive_DefaultPlanner(int n, int m, int p)
    {
        var A = RandomIntMatrix(n, m, -10, 10);
        var B = RandomIntMatrix(m, p, -10, 10);

        var expected = MatrixUtils.NaiveMultiply(A, B);

        var A2 = ToArray2D(A);
        var B2 = ToArray2D(B);
        var C2 = BlockedGeneralMatrixMultiplication.MultiplyAlpha(A2, B2); // default thresholds

        var actual = FromArray2D(C2);
        // With integer inputs and integer coefficients, this should be exact.
        AssertMatrixAlmostEqual(expected, actual, tol: 0.0);
    }

    [Theory]
    [MemberData(nameof(RandomSizeTriples))]
    //[MemberData(nameof(PlannerConfigs))]
    public void MultiplyAlpha_MatchesNaive_VariousPlannerSettings(int n, int m, int p)
    {
        var A = RandomIntMatrix(n, m, -10, 10);
        var B = RandomIntMatrix(m, p, -10, 10);

        var expected = MatrixUtils.NaiveMultiply(A, B);

        var A2 = ToArray2D(A);
        var B2 = ToArray2D(B);

        foreach (var cfg in PlannerConfigs().Select(x => (baseThreshold: (int)x[0], idealBlock: (int)x[1])))
        {
            var C2 = BlockedGeneralMatrixMultiplication.MultiplyAlpha(A2, B2, cfg.baseThreshold, cfg.idealBlock);
            var actual = FromArray2D(C2);
            AssertMatrixAlmostEqual(expected, actual, tol: 0.0);
        }
    }
}