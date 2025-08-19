using BenchmarkDotNet.Attributes;
using MatrixMultiplication.Utils;

namespace MatrixMultiplication.Benchmarks;

[BenchmarkCategory("Formula", "Array")]
public class FormulaArrayBenchmark : BenchmarkBase
{
    [Benchmark(Description = "MultiplyWithFormula(double[,], double[,], Formula)")]
    public double[,] Formula_Array()
        => MatrixUtils.MultiplyWithFormula(A_array, B_array, formula);
}