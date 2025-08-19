namespace MatrixMultiplication;

/// <summary>
/// Pre-Calculated metadata for the algorithms.
/// </summary>
/// <param name="n"></param>
/// <param name="m"></param>
/// <param name="p"></param>
/// <param name="R">The number of product terms (rank) (i.e., Terms.Count()).</param>
/// <param name="NnzU">Number of nonzero coefficients in the U blocks.</param>
/// <param name="NnzV">Number of nonzero coefficients in the V blocks.</param>
/// <param name="NnzW">Number of nonzero coefficients in the W blocks.</param>
public readonly record struct AlgoMeta(int n, int m, int p, int R, int NnzU, int NnzV, int NnzW);