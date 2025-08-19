using System.Globalization;
using System.Text;

namespace MatrixMultiplication.Utils;

public static class ProductTermExtensions
{
    /// <summary>
    /// Generates C# code that constructs an equivalent ProductTerm.
    /// Returns a single expression (no trailing semicolon).
    /// </summary>
    public static string ToCode(this ProductTerm term)
    {
        return $"new ProductTerm({MatrixToCode(term.CoeffsA)}, {MatrixToCode(term.CoeffsB)}, {MatrixToCode(term.CoeffsC)})";
    }

    private static string MatrixToCode(Matrix<double> matrix)
    {
        var data = matrix.ToArray(); // double[,]
        var rows = data.GetLength(0);
        var cols = data.GetLength(1);

        var builder = new StringBuilder();
        builder.AppendLine();
        builder.Append("    Matrix<double>.Build.DenseOfArray(new double[,] { ");

        for (int i = 0; i < rows; i++)
        {
            builder.Append("{ ");
            for (int j = 0; j < cols; j++)
            {
                if (j > 0)
                {
                    builder.Append(", ");
                }
                builder.Append(FormatDouble(data[i, j]));
            }
            builder.Append(" }");
            if (i < rows - 1) builder.Append(", ");
        }

        builder.Append(" })");
        return builder.ToString();
    }

    private static string FormatDouble(double value)
        => value.ToString("R", CultureInfo.InvariantCulture); // exact round-trip
}