using System.Globalization;
using System.Numerics;

namespace MatrixMultiplication.Tests;

public static class FormulaLoaderTests
{
    [Flags]
    public enum CompositionFileType
    {
        None = 0b_0000_0000,
        Transposed = 0b_0000_0001,
        Complex = 0b_0000_0010,
    }

    public sealed class LoadRealFormulaFromJsonTests
    {
        [Theory]
        [InlineData(4,5,7, CompositionFileType.None)]
        [InlineData(4,6,6, CompositionFileType.None)]
        [InlineData(4,6,7, CompositionFileType.None)]
        [InlineData(4,7,7.1, CompositionFileType.None)]
        [InlineData(4,7,7.2, CompositionFileType.None)]
        [InlineData(5,5,6.1, CompositionFileType.None)]
        [InlineData(5,5,6.2, CompositionFileType.None)]
        [InlineData(5,5,7.1, CompositionFileType.None)]
        [InlineData(5,5,7.2, CompositionFileType.None)]   
        [InlineData(5,5,7.3, CompositionFileType.None)]
        [InlineData(5,5,7.4, CompositionFileType.None)]
        [InlineData(5,5,7.5, CompositionFileType.None)]
        [InlineData(5,5,7.6, CompositionFileType.None)]
        [InlineData(5,5,7.7, CompositionFileType.None)]
        public void ShouldLoadDecompositionFile(int m, int n, decimal p, CompositionFileType flags)
        {
            // arrange
            var transposedSuffix = flags.HasFlag(CompositionFileType.Transposed) ? ".T" : "";
            var complexSuffix = flags.HasFlag(CompositionFileType.Complex) ? ".complex" : "";
            var fileName = $"{m}{n}{p.ToString("0.#", CultureInfo.InvariantCulture)}{transposedSuffix}{complexSuffix}.json";

            var filePath = Path.Combine("Decompositions", fileName);

            // act
            var result = FormulaLoader.LoadRealFormulaFromJson(filePath, m, n, (int)p);

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
            if (result.TryPickT0(out var real, out var complex))
            {
                var expected = NaiveMultiply(X, Y);            // double[,]
                var actual   = EvaluateReal(real, X, Y);       // double[,]
                AssertEqual(expected, actual, tol);
            }
            else
            {
                var expected = NaiveMultiplyComplex(X, Y);     // Complex[,]
                var actual   = EvaluateComplex(complex, X, Y); // Complex[,]
                AssertEqual(expected, actual, tol);
            }
        }

        static void FillRandomInt(double[,] a, int min, int max, Random rng)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rng.Next(min, max + 1);
        }

        static double[,] NaiveMultiply(double[,] A, double[,] B)
        {
            int n = A.GetLength(0), m = A.GetLength(1), p = B.GetLength(1);
            var C = new double[n, p];
            for (int i = 0; i < n; i++)
                for (int k = 0; k < p; k++)
                {
                    double sum = 0;
                    for (int j = 0; j < m; j++)
                        sum += A[i, j] * B[j, k];
                    C[i, k] = sum;
                }
            return C;
        }

        static Complex[,] NaiveMultiplyComplex(double[,] A, double[,] B)
        {
            int n = A.GetLength(0), m = A.GetLength(1), p = B.GetLength(1);
            var C = new Complex[n, p];
            for (int i = 0; i < n; i++)
                for (int k = 0; k < p; k++)
                {
                    Complex sum = Complex.Zero;
                    for (int j = 0; j < m; j++)
                        sum += new Complex(A[i, j], 0) * new Complex(B[j, k], 0);
                    C[i, k] = sum;
                }
            return C;
        }

        static double[,] EvaluateReal(Formula f, double[,] X, double[,] Y)
        {
            int n = X.GetLength(0), m = X.GetLength(1), p = Y.GetLength(1);
            var C = new double[n, p];

            foreach (var term in f.Terms) // assumes ProductTerm exposes A,B,C as MathNet matrices
            {
                // α_t = <A_t, X>  (Frobenius inner product)
                double alpha = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        alpha += term.CoeffsA[i, j] * X[i, j];

                // β_t = <B_t, Y>
                double beta = 0;
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < p; k++)
                        beta += term.CoeffsB[j, k] * Y[j, k];

                // C += α_t * β_t * C_t
                double ab = alpha * beta;
                for (int i = 0; i < n; i++)
                    for (int k = 0; k < p; k++)
                        C[i, k] += ab * term.CoeffsC[i, k];
            }

            return C;
        }

        static Complex[,] EvaluateComplex(ComplexFormula f, double[,] X, double[,] Y)
        {
            int n = X.GetLength(0), m = X.GetLength(1), p = Y.GetLength(1);
            var C = new Complex[n, p];

            foreach (var term in f.Terms) // assumes ComplexProductTerm exposes A,B,C as MathNet Complex matrices
            {
                // α_t = <A_t, X>
                Complex alpha = Complex.Zero;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        alpha += term.CoeffsA[i, j] * X[i, j];

                // β_t = <B_t, Y>
                Complex beta = Complex.Zero;
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < p; k++)
                        beta += term.CoeffsB[j, k] * Y[j, k];

                // C += α_t * β_t * C_t
                Complex ab = alpha * beta;
                for (int i = 0; i < n; i++)
                    for (int k = 0; k < p; k++)
                        C[i, k] += ab * term.CoeffsC[i, k];
            }

            return C;
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

        static void AssertEqual(Complex[,] expected, Complex[,] actual, double tol)
        {
            int n = expected.GetLength(0), p = expected.GetLength(1);
            Assert.Equal(n, actual.GetLength(0));
            Assert.Equal(p, actual.GetLength(1));

            for (int i = 0; i < n; i++)
                for (int k = 0; k < p; k++)
                {
                    var diff = expected[i, k] - actual[i, k];
                    Assert.True(diff.Magnitude <= tol,
                        $"Mismatch at ({i},{k}): expected {expected[i, k]}, actual {actual[i, k]}");
                }
        }
    }
}