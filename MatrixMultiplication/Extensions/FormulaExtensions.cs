using System.Text;

namespace MatrixMultiplication.Utils;

public static class FormulaExtensions
{
    /// <summary>
    /// Generates C# code that constructs an equivalent Formula.
    /// Returns a single expression (no trailing semicolon).
    /// </summary>
    public static string ToCode(this Formula formula)
    {
        var builder = new StringBuilder();
        builder
            .Append("new Formula(")
            .Append(formula.N).Append(", ")
            .Append(formula.M).Append(", ")
            .Append(formula.P).Append(", new [] { ");

        bool first = true;
        foreach (var term in formula.Terms)
        {
            if (!first) builder.Append(", ");
            first = false;
            builder.AppendLine();
            builder.Append(term.ToCode());
        }

        builder.Append(" })");
        return builder.ToString();
    }
}