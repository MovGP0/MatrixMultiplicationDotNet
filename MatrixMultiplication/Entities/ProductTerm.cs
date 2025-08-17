namespace MatrixMultiplication;

public sealed class ProductTerm(
    Matrix<double> coeffsA,
    Matrix<double> coeffsB,
    Matrix<double> coeffsC)
{
    public Matrix<double> CoeffsA { get; } = coeffsA;
    public Matrix<double> CoeffsB { get; } = coeffsB;
    public Matrix<double> CoeffsC { get; } = coeffsC;
}