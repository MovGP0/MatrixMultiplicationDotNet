using System.Numerics;

namespace MatrixMultiplication;

public static partial class MatrixUtils
{
    private static Matrix<Complex> CreateComplexDenseMatrix(int rows, int cols)
    {
        return Matrix<Complex>.Build.Dense(rows, cols);
    }

    public static Matrix<double> MultiplyWithComplexFormula(
        Matrix<double> A,
        Matrix<double> B,
        ComplexFormula formula)
    {
        var (n, m, p) = (formula.N, formula.M, formula.P);

        // Assert that A and B have compatible dimensions
        if (A.RowCount != n || A.ColumnCount != m)
            throw new ArgumentException($"Matrix A must be {n}x{m} but was {A.RowCount}x{A.ColumnCount}.");

        if (B.RowCount != m || B.ColumnCount != p)
            throw new ArgumentException($"Matrix B must be {m}x{p} but was {B.RowCount}x{B.ColumnCount}.");

        var C = CreateComplexDenseMatrix(n, p);
        foreach (var term in formula.Terms)
        {
            Complex LA = 0, LB = 0;
            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                var coeffA = term.CoeffsA[i, j];
                if (coeffA != 0)
                {
                    LA += coeffA * A[i, j];
                }
            }

            for (int i = 0; i < m; i++)
            for (int j = 0; j < p; j++)
            {
                var coeffB = term.CoeffsB[i, j];
                if (coeffB != 0)
                {
                    LB += coeffB * B[i, j];
                }
            }

            Complex Pk = LA * LB;
            if (Pk == 0)
            {
                continue;
            }

            for (int i = 0; i < n; i++)
            for (int j = 0; j < p; j++)
            {
                var coeffC = term.CoeffsC[i, j];
                if (coeffC != 0)
                {
                    C[i, j] += coeffC * Pk;
                }
            }
        }

        // Copy the real parts of the complex matrix to the result matrix
        var resultMatrix = CreateDenseMatrix(n, p);
        for (int i = 0; i < n; i++)
        for (int j = 0; j < p; j++)
        {
            resultMatrix[i, j] = C[i, j].Real;
        }

        return resultMatrix;
    }
}