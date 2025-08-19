namespace MatrixMultiplication;

public sealed class CompiledTerm
{
    public (int ai, int ak, double c)[] A; // n*m nonzeros
    public (int bk, int bj, double c)[] B; // m*p nonzeros
    public (int a, int b, double c)[] C; // n*p nonzeros
}