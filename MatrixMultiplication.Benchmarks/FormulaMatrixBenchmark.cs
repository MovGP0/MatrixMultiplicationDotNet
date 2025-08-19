using BenchmarkDotNet.Attributes;
using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.Utils;

namespace MatrixMultiplication.Benchmarks;

[BenchmarkCategory("Formula", "Matrix")]
public class FormulaMatrixBenchmark : BenchmarkBase
{
    [Benchmark(Description = "MultiplyWithFormula(Matrix<double>, Matrix<double>, Formula)")]
    public Matrix<double> Formula_Matrix()
        => MatrixUtils.MultiplyWithFormula(A_matrix, B_matrix, formula);
}