// Auto-generated AlphaTensor factorization method for (2,2,2).

namespace MatrixMultiplication.KnownAlgorithms;

public static partial class AlphaTensorFormulaBuilder
{

public static Formula Build2x2x2Formula_Real() 
{
    const int n = 2, m = 2, p = 2;

    // U: 4 x 7, V: 4 x 7, W: 4 x 7
    double[,] u = new double[,]
    {
        {0.0, 1.0, 1.0, 0.0, 1.0, 1.0, 0.0},
        {0.0, 0.0, -1.0, 1.0, 0.0, 0.0, 0.0},
        {1.0, 1.0, 1.0, 0.0, 1.0, 0.0, 0.0},
        {-1.0, -1.0, -1.0, 0.0, 0.0, 0.0, 1.0}
    };

    double[,] v = new double[,]
    {
        {0.0, 0.0, 0.0, 0.0, 1.0, 1.0, 0.0},
        {1.0, 1.0, 0.0, 0.0, 1.0, 0.0, 1.0},
        {0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0},
        {0.0, 1.0, 1.0, 0.0, 1.0, 0.0, 1.0}
    };

    double[,] w = new double[,]
    {
        {0.0, 0.0, 0.0, 1.0, 0.0, 1.0, 0.0},
        {0.0, -1.0, 0.0, 0.0, 1.0, -1.0, -1.0},
        {-1.0, 1.0, -1.0, -1.0, 0.0, 0.0, 0.0},
        {1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0}
    };

    return BuildFormulaFromUVW(n, m, p, u, v, w);
}
}
