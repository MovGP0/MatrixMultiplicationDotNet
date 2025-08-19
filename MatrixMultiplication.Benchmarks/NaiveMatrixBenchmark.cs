using BenchmarkDotNet.Attributes;
using MathNet.Numerics.LinearAlgebra;
using MatrixMultiplication.Utils;

namespace MatrixMultiplication.Benchmarks;

[BenchmarkCategory("Naive", "Matrix")]
public class NaiveMatrixBenchmark : BenchmarkBase
{
    [Benchmark(Description = "NaiveMultiply(Matrix<double>, Matrix<double>)")]
    public Matrix<double> Naive_Matrix()
        => MatrixUtils.NaiveMultiply(A_matrix, B_matrix);
}