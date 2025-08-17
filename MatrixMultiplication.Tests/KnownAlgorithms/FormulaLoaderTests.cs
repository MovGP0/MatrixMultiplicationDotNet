using System.Globalization;

namespace MatrixMultiplication.Tests.KnownAlgorithms;

public static class FormulaLoaderTests
{
    public sealed class LoadRealFormulaFromJsonTests
    {
        [Theory]
        [InlineData(4,5,7)]
        [InlineData(4,6,6)]
        [InlineData(4,6,7)]
        [InlineData(4,7,7.1)]
        [InlineData(4,7,7.2)]
        [InlineData(5,5,6.1)]
        [InlineData(5,5,6.2)]
        [InlineData(5,5,7.1)]
        [InlineData(5,5,7.2)]   
        [InlineData(5,5,7.3)]
        [InlineData(5,5,7.4)]
        [InlineData(5,5,7.5)]
        [InlineData(5,5,7.6)]
        [InlineData(5,5,7.7)]
        public void ShouldLoadDecompositionFile(int m, int n, decimal p)
        {
            // arrange
            var fileName = $"{m}{n}{p.ToString("0.#", CultureInfo.InvariantCulture)}.json";

            var filePath = Path.Combine("Decompositions", fileName);

            // act
            var real = FormulaLoader.LoadRealFormulaFromJson(filePath, m, n, (int)p);

            // We call the loader with (m, n, p), so inputs should be (rows=m)×(inner=n) and (inner=n)×(cols=p).
            var rows  = m;
            var inner = n;
            var cols  = (int)p;

            // random integer matrices in [-10, 10]
            var rng = new Random(12345);
            double[,] X = new double[rows, inner];
            double[,] Y = new double[inner, cols];
            FillRandomInt(X, -10, 10, rng);
            FillRandomInt(Y, -10, 10, rng);

            // compare formula vs naive
            const double tol = 1e-9;

            // assert
            var expected = MatrixUtils.NaiveMultiply(X, Y); // double[,]
            var actual = MatrixUtils.MultiplyWithFormula(X, Y, real); // double[,]
            AssertEqual(expected, actual, tol);
        }

        static void FillRandomInt(double[,] a, int min, int max, Random rng)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rng.Next(min, max + 1);
        }

        static void AssertEqual(double[,] expected, double[,] actual, double tol)
        {
            int n = expected.GetLength(0), p = expected.GetLength(1);
            Assert.Equal(n, actual.GetLength(0));
            Assert.Equal(p, actual.GetLength(1));

            for (int i = 0; i < n; i++)
                for (int k = 0; k < p; k++)
                    Assert.True(Math.Abs(expected[i, k] - actual[i, k]) <= tol,
                        $"Mismatch at ({i},{k}): expected {expected[i, k]}, actual {actual[i, k]}");
        }
    }
}