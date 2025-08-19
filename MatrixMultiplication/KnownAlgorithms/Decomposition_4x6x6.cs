namespace MatrixMultiplication.KnownAlgorithms;

public static class Decomposition_4x6x6
{
    public static Formula Build4x6x6Formula()
    {
        return new Formula(4, 6, 6,
        [
            new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -2, -1, -1, 1, 1, 0 }, { 1, 1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 2, 0, 1 }, { 0, 0, 0, 2, 0, 1 },
                        { 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, -4, 2, 2, 0, 0 }, { 2, -4, 2, 2, 0, 0 },
                        { 1, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, 1, 1 }, { -1, -1, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, -1, -1, -1, 0, 0 }, { -1, 1, 1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 1, -2, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 3, -1, 1, 0 }, { -1, 1, 3, -1, 1, 0 }, { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -2, 1, 1, 0, 0 }, { 0, 2, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, -1, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, -1, 2, 0 }, { 0, 0, 0, -1, 2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -3, 1, 0, 0 }, { 2, -1, -3, 1, 0, 0 }, { 2, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -2, -1, -1, 0, 2, 0 }, { 2, 1, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, 1 }, { 0, 0, 0, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0 }, { 0, -2, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 1, -1, -1, -1, 0, 0 }, { -1, 1, 1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 2, 0 }, { 0, 0, -1, 0, 2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, -1, 1, 0 }, { 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0 }, { 0, 0, 0, 2, 0, 0 },
                        { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, -1, -1 }, { 0, 0, 1, -1, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 1, 1, 0 }, { 1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, -2, 1 }, { 0, 0, 0, 0, -2, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, -1 }, { 0, 0, -1, 1, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -2, 2 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 1, -1, 1, 0, 0 }, { 0, 1, -1, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 1, -2, 1, 1, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 3, -1, 1, 0 }, { -1, 1, 3, -1, 1, 0 }, { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { -1, 1, 1, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -2, 2, 2, 0, 0 }, { 0, -2, 2, 2, 0, 0 },
                        { 0, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, -4, 2, 2, 0, 0 }, { 2, -4, 2, 2, 0, 0 },
                        { 1, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, 1, 1 }, { -1, -1, -1, -1, 1, 1 }, { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, -2, 2, 3, -1, 4 }, { 0, -1, 1, 1, -1, 2 },
                        { 0, -1, 1, 1, -1, 2 }, { 0, 1, -1, -1, 1, -2 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -3, 1, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 1, -1, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, -1, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { -1, 0, 1, -1, 0, 0 }, { -1, 0, 1, -1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, -2, 2, 2, 0, 1 }, { 0, -2, 2, 2, 0, 1 },
                        { 0, -1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -4, 2, 2, 0, 0 }, { 0, -4, 2, 2, 0, 0 },
                        { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { -1, -1, -1, -1, 1, 1 }, { 0, 0, 0, -1, 1, 2 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, 0 }, { 0, 0, 1, -1, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -2, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 1, -1, 0, 1 }, { 1, 1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 1, -1 },
                        { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 1, -2, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 3, -1, 1, 0 }, { 0, 1, 3, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, -1, 1, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 1, 0, -1 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, -1, 1, 0, -1 }, { 0, -1, 1, -1, 0, 1 }, { 0, 1, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, -2, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { -2, 2, 6, -2, 2, 0 }, { -2, 2, 6, -2, 2, 0 }, { 1, 1, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }, { 1, -2, 1, 1, 0, 0 }, { 1, -2, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 1, -2, -1 }, { 0, 0, 0, -1, 2, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, -4, 2, 2, 0, 0 }, { 1, -4, 2, 2, 0, 0 },
                        { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 1, 0, -1, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 2, 0 }, { 0, 0, 0, -1, 2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, -1, 2, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -4, 2, 2, 0, 0 }, { 0, -4, 2, 2, 0, 0 },
                        { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, -1, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, -2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, -2, 0, 0 }, { 0, 2, -1, -2, 0, 0 },
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 1, -2, 0 }, { 0, 0, 0, 1, -2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 1, -2, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 2, 1, 1, -1, -1, 0 }, { -2, -1, -1, 1, 1, 0 }, { 2, 1, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 1 }, { 0, 0, 0, 2, 0, 1 },
                        { 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, -4, 2, 2, 0, 2 }, { 2, -4, 2, 2, 0, 1 },
                        { 1, -2, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, 1, 1 }, { -1, -1, -1, -1, 1, 1 }, { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 2, -4, 2, 2, 0, 1 }, { 2, -4, 2, 2, 0, 1 },
                        { 1, -2, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, 1, 1 }, { 0, -1, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, -2, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -2, 2, 2, -2, 4 }, { 0, -1, 1, 1, -1, 2 },
                        { 0, -1, 1, 1, -1, 2 }, { 0, 1, -1, -1, 1, -2 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, -3, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -2, -1, -1, 1, 1, 0 }, { 2, 1, 1, -1, -1, 0 }, { -2, -1, -1, 1, 1, 0 },
                        { -2, -1, -1, 0, 2, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 1 }, { 0, 0, 0, 0, -2, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -4, 2, 2, 0, 1 }, { 0, -4, 2, 2, 0, 1 },
                        { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 1, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 1, 1, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 0, 1 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, -4, 2, 2, 1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { -1, 1, 3, -1, 1, 0 }, { -1, 1, 3, -1, 1, 0 }, { 1, 1, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 2, 1, 1, 0, -2, 0 }, { -2, -1, -1, 0, 2, 0 }, { 2, 1, 1, 0, -2, 0 }, { 2, 1, 1, 0, -2, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 1, -1, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, -1, -2, 0, -2 }, { 0, -1, 1, 2, 0, 2 }, { 0, -1, 1, 2, 0, 2 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 2, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 0 }, { 0, -1, 1, 0, 0, 0 }, { 0, -1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 2, -2, -4, 0, -4 }, { 0, 1, -1, -2, 0, -2 },
                        { 0, 1, -1, -2, 0, -2 }, { 0, -1, 1, 2, 0, 2 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 2, -1, -1, 1, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 1, 1, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -2, -2, 0 }, { 0, 0, 0, -1, -1, 0 },
                        { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 2, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, -1, 1, -1, -2 }, { 0, -1, 1, -1, 0, 1 }, { 0, 1, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, -1, 0, 1 }, { 0, 1, -1, 1, 0, -1 }, { 0, -1, 1, -1, 0, 1 }, { 2, 1, 1, 0, -2, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, -1, 0 }, { 0, 0, 1, -1, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, -1, -1, 0 },
                        { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -2, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, -1, -1, -1, 0, 0 }, { 0, 1, 1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 2, -1, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, -1, -2, 0, 0, 0 }, { -1, 1, 2, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0 }, { 0, 2, -1, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 }, { -1, 1, 1, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 1, -1, -1, 1, -2 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 3, -1, 1, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 },
                        { -1, -1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 2, 1, 1, -1, -1, 0 }, { -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, -1, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -2, 2, 2, 0, 2 }, { 0, -2, 2, 2, 0, 1 },
                        { 0, -1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, -1, 1, -1, 0, 0 }, { 0, -1, 1, -1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 2, 1, 1, 0, -2, 0 }, { -1, -1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, -1, 0, 0 }, { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, 1 }, { 1, 0, 0, 0, -1, 1 },
                        { 1, 0, 0, 0, -1, 1 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -2, -1, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, -1, 1 }, { 0, 0, 0, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 1, -2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, -2, 2, 2, 0, 1 }, { 0, -2, 2, 2, 0, 1 },
                        { 0, -1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, 1, 1 }, { 0, -1, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 2, 1, 1, 0, -2, 0 }, { -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, -1, -1, 1 }, { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -2, 2, 2, 0, 0 }, { 0, -2, 2, 2, 0, 0 },
                        { 0, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, -1, 2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 3, -2, -2, 0, 0 }, { 0, 3, -2, -2, 0, 0 },
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, -2, -1 }, { 0, 0, 0, -1, 2, 1 }, { 0, 0, 0, 1, -2, -1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -3, 2, 2, 0, 0 }, { 0, -3, 2, 2, 0, 0 },
                        { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }, { 0, -1, 1, 1, 0, 0 }, { 0, -1, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 2 }, { 0, 0, 0, 2, 0, 1 },
                        { 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, -1, -1 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -2, -1, -1, 0, 2, 0 }, { 1, 1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, -1, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -4, 2, 2, 0, 0 }, { 0, -4, 2, 2, 0, 0 },
                        { 0, -2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { -1, -1, -1, -1, 1, 1 }, { -1, -1, -1, -1, 1, 1 }, { 1, 1, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -4, 2, 2, 0, 2 }, { 0, -4, 2, 2, 0, 1 },
                        { 0, -2, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { -1, -1, -1, -1, 1, 1 }, { -1, -1, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, -2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 4, -2, -2, 0, 0 }, { 0, 4, -2, -2, 0, 0 },
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { -1, -1, -1, 0, 0, 0 }, { -1, -1, -1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 1, -1, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 1, 2, -1, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, -1, -2, 0, 0, 0 }, { -1, 1, 1, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, -1, 0, 0 }, { 0, -1, 1, 1, 0, 0 }, { 0, -1, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 2, 1, 1, -1, -1, 0 }, { -1, -1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, -2, 1 }, { 0, 0, 0, 0, -2, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, -1, 0 }, { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 2, 0, 1 }, { 0, 0, 0, 2, 0, 1 },
                        { 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { -1, 1, 1, 1, 1, 1 }, { -1, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 1, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 1, -1 },
                        { 0, 0, 0, 0, 1, -1 }, { 0, 1, -1, -1, 1, -2 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 1, -1, -1, 1, -2 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 3, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, -1, 0, 1 }, { 1, 1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, -1, 1 },
                        { 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 3, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -2, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, -2, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 4, -2, -2, 0, 0 }, { -1, 4, -2, -2, 0, 0 },
                        { 0, 2, -1, -1, 0, 0 }, { 0, -2, 1, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 1, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 1, 1 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -2, -1, -1, 0, 2, 0 }, { 2, 1, 1, 0, -2, 0 }, { -2, -1, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 1, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -2, -2, 0 }, { 0, 0, 0, 2, 2, 0 }, { -2, 4, -2, 0, 0, 0 }, { -1, 2, -1, -1, -1, 0 },
                        { -1, 2, -1, -1, -1, 0 }, { 1, -2, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 1, 0, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1, 0 },
                        { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0 }, { 0, -2, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 1, 1, 1, 0, 0 } }))
        ]);
    }

    public static AlgoMeta Build4x6x6Metadata()
    {
        return new AlgoMeta { n = 4, m = 6, p = 6, R = 106, NnzU = 529, NnzV = 836, NnzW = 535 };
    }
}