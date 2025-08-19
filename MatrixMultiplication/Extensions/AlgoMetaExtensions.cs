namespace MatrixMultiplication.Utils;

public static class AlgoMetaExtensions
{
    /// <summary>
    /// Generates C# code that constructs an equivalent AlgoMeta.
    /// Returns a single expression (no trailing semicolon).
    /// </summary>
    public static string ToCode(this AlgoMeta metadata)
    {
        return $"new AlgoMeta({metadata.n}, {metadata.m}, {metadata.p}, {metadata.R}, {metadata.NnzU}, {metadata.NnzV}, {metadata.NnzW})";
    }
}