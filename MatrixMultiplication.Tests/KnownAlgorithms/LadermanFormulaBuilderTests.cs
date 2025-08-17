using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.KnownAlgorithms;

namespace MatrixMultiplication.Tests.KnownAlgorithms;

public sealed class LadermanFormulaBuilderTests
{
    private static readonly Random Rng = new(123456); // reproducible

    private static Matrix<double> RandIntMatrix(int rows, int cols, int min = -10, int max = 10)
    {
        var M = Matrix<double>.Build.Dense(rows, cols);
        for (int r = 0; r < rows; r++)
        for (int c = 0; c < cols; c++)
        {
            M[r, c] = Rng.Next(min, max + 1);
        }

        return M;
    }

    [Fact]
    public void Laderman_3x3_RandomProductsMatchNaive()
    {
        var f = LadermanFormulaBuilder.BuildLaderman3x3Formula();

        const int Trials = 2000;
        for (int t = 0; t < Trials; t++)
        {
            var A = RandIntMatrix(3, 3);
            var B = RandIntMatrix(3, 3);

            var expected = MatrixUtils.NaiveMultiply(A, B);
            var actual   = MatrixUtils.MultiplyWithFormula(A, B, f);

            AssertMatrixAlmostEqual(expected, actual);
        }
    }

    /// <summary>
    /// A couple of edge cases for extra confidence
    /// </summary>
    [Fact]
    public void Laderman_3x3_ZeroAndIdentity()
    {
        var f = LadermanFormulaBuilder.BuildLaderman3x3Formula();

        var Z = Matrix<double>.Build.Dense(3, 3, 0.0);
        var I = Matrix<double>.Build.DenseIdentity(3);

        AssertMatrixAlmostEqual(Z, MatrixUtils.MultiplyWithFormula(Z, Z, f));
        AssertMatrixAlmostEqual(Z, MatrixUtils.MultiplyWithFormula(Z, I, f));
        AssertMatrixAlmostEqual(Z, MatrixUtils.MultiplyWithFormula(I, Z, f));
        AssertMatrixAlmostEqual(I, MatrixUtils.MultiplyWithFormula(I, I, f));
    }

    private static void AssertMatrixAlmostEqual(Matrix<double> expected, Matrix<double> actual, double tol = 1e-9)
    {
        Assert.Equal(expected.RowCount, actual.RowCount);
        Assert.Equal(expected.ColumnCount, actual.ColumnCount);

        for (int r = 0; r < expected.RowCount; r++)
        for (int c = 0; c < expected.ColumnCount; c++)
        {
            var diff = Math.Abs(expected[r, c] - actual[r, c]);
            if (diff > tol)
                throw new Xunit.Sdk.XunitException(
                    $"Mismatch at ({r},{c}): expected {expected[r, c]}, actual {actual[r, c]}, |diff|={diff}");
        }
    }
}