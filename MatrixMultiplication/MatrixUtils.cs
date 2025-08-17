namespace MatrixMultiplication;

public static partial class MatrixUtils
{
    private static Matrix<double> CreateDenseMatrix(int rows, int cols)
    {
        return Matrix<double>.Build.Dense(rows, cols);
    }

    public static void FillMatrixRandom(Matrix<double> mat, int? seed = null)
    {
        Random rng = seed is not { } seedValue
            ? new()
            : new(seedValue);

        for (int i = 0; i < mat.RowCount; i++)
        for (int j = 0; j < mat.ColumnCount; j++)
        {
            mat[i, j] = 1.0 + rng.NextDouble() * 4.0;
        }
    }

    public static Matrix<double> Multiply(Matrix<double> A, Matrix<double> B)
    {
        return A * B;
    }

    public static Matrix<double> NaiveMultiply(Matrix<double> A, Matrix<double> B)
    {
        int n = A.RowCount;
        int m = A.ColumnCount;
        int p = B.ColumnCount;

        var C = CreateDenseMatrix(n, p);
        for (int i = 0; i < n; i++)
        for (int j = 0; j < p; j++)
        {
            double sum = 0;
            for (int k = 0; k < m; k++)
            {
                sum += A[i, k] * B[k, j];
            }

            C[i, j] = sum;
        }

        return C;
    }

    public static Matrix<double> MultiplyWithFormula(
        Matrix<double> A,
        Matrix<double> B,
        Formula formula)
    {
        var (n, m, p) = (formula.N, formula.M, formula.P);
        
        // Assert that A and B have compatible dimensions
        if (A.RowCount != n || A.ColumnCount != m)
            throw new ArgumentException($"Matrix A must be {n}x{m} but was {A.RowCount}x{A.ColumnCount}.");

        if (B.RowCount != m || B.ColumnCount != p)
            throw new ArgumentException($"Matrix B must be {m}x{p} but was {B.RowCount}x{B.ColumnCount}.");

        var C = CreateDenseMatrix(n, p);
        foreach (var term in formula.Terms)
        {
            double LA = 0, LB = 0;

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

            double Pk = LA * LB;
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

        return C;
    }

    public static bool CompareMatrices(
        Matrix<double> M1,
        Matrix<double> M2,
        double eps = 1e-6)
    {
        if (M1.RowCount != M2.RowCount || M1.ColumnCount != M2.ColumnCount)
        {
            return false;
        }

        for (int i = 0; i < M1.RowCount; i++)
        for (int j = 0; j < M1.ColumnCount; j++)
            if (Math.Abs(M1[i, j] - M2[i, j]) > eps)
                return false;

        return true;
    }

    public static void ValidateTermDims(
        Matrix<double> A, Matrix<double> B, Matrix<double> C,
        int n, int m, int p, string termName)
    {
        if (A.RowCount != n || A.ColumnCount != m)
            throw new ArgumentException($"{termName}.CoeffsA must be {n}x{m} but was {A.RowCount}x{A.ColumnCount}.");
        if (B.RowCount != m || B.ColumnCount != p)
            throw new ArgumentException($"{termName}.CoeffsB must be {m}x{p} but was {B.RowCount}x{B.ColumnCount}.");
        if (C.RowCount != n || C.ColumnCount != p)
            throw new ArgumentException($"{termName}.CoeffsC must be {n}x{p} but was {C.RowCount}x{C.ColumnCount}.");
    }
}