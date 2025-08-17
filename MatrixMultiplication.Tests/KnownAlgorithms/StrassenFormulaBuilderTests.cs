using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.KnownAlgorithms;

namespace MatrixMultiplication.Tests.KnownAlgorithms;

public sealed class StrassenFormulaBuilderTests
{
    private static readonly Random Rng = new(123456); // reproducible

    private static Matrix<double> RandIntMatrix(int rows, int cols, int min = -10, int max = 10)
    {
        var M = Matrix<double>.Build.Dense(rows, cols);
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                M[i, j] = Rng.Next(min, max + 1);
        return M;
    }

    private static void AssertMatrixAlmostEqual(Matrix<double> expected, Matrix<double> actual, double tol = 1e-9)
    {
        Assert.Equal(expected.RowCount, actual.RowCount);
        Assert.Equal(expected.ColumnCount, actual.ColumnCount);

        for (int i = 0; i < expected.RowCount; i++)
        {
            for (int j = 0; j < expected.ColumnCount; j++)
            {
                var diff = Math.Abs(expected[i, j] - actual[i, j]);
                if (diff > tol)
                    throw new Xunit.Sdk.XunitException(
                        $"Mismatch at ({i},{j}): expected {expected[i, j]}, actual {actual[i, j]}, |diff|={diff}");
            }
        }
    }

    [Fact]
    public void Strassen_2x2_RandomProductsMatchNaive()
    {
        var f = StrassenFormulaBuilder.BuildStrassen2x2Formula();

        const int Trials = 2000;
        for (int t = 0; t < Trials; t++)
        {
            var A = RandIntMatrix(2, 2);
            var B = RandIntMatrix(2, 2);

            var expected = MatrixUtils.NaiveMultiply(A, B);
            var actual   = MatrixUtils.MultiplyWithFormula(A, B, f);

            AssertMatrixAlmostEqual(expected, actual);
        }
    }

    /// <summary>
    /// A couple of edge cases for extra confidence
    /// </summary>
    [Fact]
    public void Strassen_2x2_ZeroAndIdentity()
    {
        var f = StrassenFormulaBuilder.BuildStrassen2x2Formula();

        var Z = Matrix<double>.Build.Dense(2, 2, 0.0);
        var I = Matrix<double>.Build.DenseIdentity(2);

        AssertMatrixAlmostEqual(Z, MatrixUtils.MultiplyWithFormula(Z, Z, f)); // 0·0 = 0
        AssertMatrixAlmostEqual(Z, MatrixUtils.MultiplyWithFormula(Z, I, f)); // 0·I = 0
        AssertMatrixAlmostEqual(Z, MatrixUtils.MultiplyWithFormula(I, Z, f)); // I·0 = 0
        AssertMatrixAlmostEqual(I, MatrixUtils.MultiplyWithFormula(I, I, f)); // I·I = I
    }
}