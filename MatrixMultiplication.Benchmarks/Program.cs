using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace MatrixMultiplication.Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        var shortJob = Job.Default
            .WithId("ShortRun")
            .WithIterationCount(10)
            .WithWarmupCount(3);

        var config = DefaultConfig.Instance
            .AddJob(shortJob);

        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
            .Run(args, config);
    }
}