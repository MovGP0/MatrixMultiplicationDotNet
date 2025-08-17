namespace MatrixMultiplication;

/// <param name="N">The number of rows in matrix A.</param>
/// <param name="M">The number of columns in matrix A and rows in matrix B.</param>
/// <param name="P">Number of columns in matrix B and columns in matrix C.</param>
public record MatrixMultiplicationShape(int N, int M, int P);