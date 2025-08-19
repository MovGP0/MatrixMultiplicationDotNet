using BenchmarkDotNet.Attributes;
using MatrixMultiplication.Utils;

namespace MatrixMultiplication.Benchmarks;

[BenchmarkCategory("Naive", "Array")]
public class NaiveArrayBenchmark : BenchmarkBase
{
    [Benchmark(Baseline = true, Description = "NaiveMultiply(double[,], double[,])")]
    public double[,] Naive_Array()
        => MatrixUtils.NaiveMultiply(A_array, B_array);
}