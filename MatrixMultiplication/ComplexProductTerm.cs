using System.Numerics;

namespace MatrixMultiplication;

public sealed class ComplexProductTerm(
    Matrix<Complex> coeffsA,
    Matrix<Complex> coeffsB,
    Matrix<Complex> coeffsC)
{
    public Matrix<Complex> CoeffsA { get; } = coeffsA;
    public Matrix<Complex> CoeffsB { get; } = coeffsB;
    public Matrix<Complex> CoeffsC { get; } = coeffsC;
}