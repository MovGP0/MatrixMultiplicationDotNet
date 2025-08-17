using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.KnownAlgorithms;

namespace MatrixMultiplication.Tests.KnownAlgorithms;

public static class AlphaTensorFormulaBuilderTests
{
    public sealed class BuildFormulaTests
    {
        private static readonly Random Rng = new(123456); // reproducible

        private static Matrix<double> RandomIntMatrix(int rows, int cols, int min = -10, int max = 10)
        {
            var M = Matrix<double>.Build.Dense(rows, cols);
            for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
            {
                M[r, c] = Rng.Next(min, max + 1);
            }

            return M;
        }

        public static IEnumerable<object[]> AllRealTriples()
            => AlphaTensorFormulaBuilder
                .GetSupportedTriples()
                .Select(t => new object[] { t.n, t.m, t.p });

        [Theory]
        [MemberData(nameof(AllRealTriples))]
        public void ShouldBuildValidFormula(int n, int m, int p)
        {
            // Arrange
            var formula = AlphaTensorFormulaBuilder.BuildFormula(n, m, p);

            // Act + Assert on many random trials
            for (int trial = 0; trial < 100; trial++)
            {
                var A = RandomIntMatrix(n, m, -10, 11);
                var B = RandomIntMatrix(m, p, -10, 11);

                var expected = MatrixUtils.NaiveMultiply(A, B);
                var actual   = MatrixUtils.MultiplyWithFormula(A, B, formula);

                AssertMatrixAlmostEqual(expected, actual, 0.0); // exact for integer inputs and integer coeffs
            }
        }
    }
    
    public sealed class Build4x4x4TPUFormulaTests
    {
        private static readonly Random Rng = new(123456); // reproducible

        private static Matrix<double> RandomIntMatrix(int rows, int cols, int min = -10, int max = 10)
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
        public void ShouldBuild4x4x4TPUFormula()
        {
            // Arrange
            var formula = AlphaTensorFormulaBuilder.Build4x4x4TPUFormula();
            const int n = 4, m = 4, p = 4;

            // Act + Assert on many random trials
            for (int trial = 0; trial < 300; trial++)
            {
                var A = RandomIntMatrix(n, m, -10, 11);
                var B = RandomIntMatrix(m, p, -10, 11);

                var expected = MatrixUtils.NaiveMultiply(A, B);
                var actual   = MatrixUtils.MultiplyWithFormula(A, B, formula);

                AssertMatrixAlmostEqual(expected, actual, 0.0); // exact for integer inputs and integer coeffs
            }
        }

        [Fact]
        public void ShouldBuild4x4x4GPUFormula()
        {
            // Arrange
            var formula = AlphaTensorFormulaBuilder.Build4x4x4GPUFormula();
            const int n = 4, m = 4, p = 4;

            // Act + Assert on many random trials
            for (int trial = 0; trial < 300; trial++)
            {
                var A = RandomIntMatrix(n, m, -10, 11);
                var B = RandomIntMatrix(m, p, -10, 11);

                var expected = MatrixUtils.NaiveMultiply(A, B);
                var actual   = MatrixUtils.MultiplyWithFormula(A, B, formula);

                AssertMatrixAlmostEqual(expected, actual, 0.0); // exact for integer inputs and integer coeffs
            }
        }

        [Fact]
        public void ShouldBuild5x5Formula()
        {
            // Arrange
            var formula = AlphaTensorFormulaBuilder.Build5x5Formula();
            const int n = 5, m = 5, p = 5;

            // Act + Assert on many random trials
            for (int trial = 0; trial < 300; trial++)
            {
                var A = RandomIntMatrix(n, m, -10, 11);
                var B = RandomIntMatrix(m, p, -10, 11);

                var expected = MatrixUtils.NaiveMultiply(A, B);
                var actual   = MatrixUtils.MultiplyWithFormula(A, B, formula);

                AssertMatrixAlmostEqual(expected, actual, 0.0); // exact for integer inputs and integer coeffs
            }
        }
    }

    internal static void AssertMatrixAlmostEqual(Matrix<double> expected, Matrix<double> actual, double tol = 1e-9)
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