namespace MatrixMultiplication;

/// <summary>
/// Represents a formula for matrix multiplication. (<i>C = A•B</i>)
/// </summary>
public sealed class ComplexFormula
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ComplexFormula"/> class.
    /// </summary>
    /// <param name="shape">The type of the matrix multiplication.</param>
    /// <param name="terms">The product terms of the formula.</param>
    public ComplexFormula(MatrixMultiplicationShape shape, IEnumerable<ComplexProductTerm> terms)
    {
        Shape = shape;
        Terms = terms;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ComplexFormula"/> class.
    /// </summary>
    /// <param name="n">The number of rows in matrix A.</param>
    /// <param name="m">The number of columns in matrix A and rows in matrix B.</param>
    /// <param name="p">Number of columns in matrix B and rows in matrix C.</param>
    /// <param name="terms">The product terms of the formula.</param>
    public ComplexFormula(int n, int m, int p, IEnumerable<ComplexProductTerm> terms)
    {
        Shape = new(n, m, p);
        Terms = terms;
    }

    public MatrixMultiplicationShape Shape { get; }

    /// <summary>
    /// Number of rows in matrix A.
    /// </summary>
    public int N => Shape.N;

    /// <summary>
    /// Number of columns in matrix A and rows in matrix B.
    /// </summary>
    public int M => Shape.M;

    /// <summary>
    /// Number of columns in matrix B and rows in matrix C.
    /// </summary>
    public int P => Shape.P;

    /// <summary>
    /// The product terms of the formula.
    /// </summary>
    public IEnumerable<ComplexProductTerm> Terms { get; }
}