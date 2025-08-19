namespace MatrixMultiplication.KnownAlgorithms;

public static class Decomposition_4x6x7
{
    public static Formula Build4x6x7Formula()
    {
        return new Formula(4, 6, 7,
            new[]
            {
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, -1 }, { 0, 0, 1, -1, -1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, 0, 0 },
                        { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, -1, -1, -1, 1 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, -2, -1 }, { -1, 2, 0, -2, 0, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, -1, 2, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 0, -1 }, { 0, 0, -1, 0, 0, -1 }, { 0, 1, 1, -1, -1, 1 }, { 0, 0, -1, 0, 0, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }, { 0, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 }, { 1, 0, -1, 0, 0, -1 }, { -1, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 2, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -2, 0, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, 1 }, { 0, 0, -1, 0, 0, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 1, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 },
                        { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -2, -2, -2, 2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -2, -2, -2, 2 },
                        { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 1, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 2, -2, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, -1 }, { -1, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, 1 }, { 0, 0, -1, 1, 1, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, 0, 0 },
                        { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 1, 1, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 1, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 1 }, { 0, 0, 1, -1, -1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, -2, 0, 2, -1, -1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 },
                        { 0, -1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1 }, { 0, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -2, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -2, -1, -1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -2, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, -1, 0, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 1, 0, 0, 1 }, { 0, 0, -1, 1, 1, -1 }, { 0, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, -1, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 1, 1, -1, -1, 1 }, { 0, -1, -1, 1, 1, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0, 1 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 1, 1, 1, -1 }, { 0, 0, -1, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 1, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 1, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -2, 0, -1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 1 },
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, -1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, -1, 1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, -1, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { -1, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -1, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 1, 0, -1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 1, 0, -1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, -1 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 1, 0, 1, 0, 0, -1 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 1, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 1, 0, 1, 0, 0, -1 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 1 }, { 0, 0, 1, -1, -1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, -1, -1 }, { 0, 1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 1, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, 1, 1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 1, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, -1, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 },
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 0, -1 }, { 0, 1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, -1, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, -1, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 1, -1, -1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 0, -1 }, { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 1 }, { -1, 0, -1, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 0, -1 }, { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, -1, 0, 0, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0 }, { 0, -1, 0, 1, -1, 0 }, { 0, 1, 0, -1, 0, 0 }, { 0, -1, 0, 1, -1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 },
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, -1 }, { 0, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                        { 0, 0, 1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 0 }, { 0, 1, 1, -1, -1, 1 }, { 0, -1, 0, 1, 0, 0 }, { 0, 1, 1, -1, -1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0 }, { 0, -1, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 1, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 1, 0, 1, 0, 0, -1 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -2, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, -2, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 0, 1 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 2, 0, -2, 0, 0, 0 }, { -1, 1, 0, 1, 1, 0 }, { -2, 0, 2, 0, 0, 0 }, { 1, 1, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, -1, 0 }, { -1, 0, 0, 1, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 1, 2, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 2, 1, 1, 1 },
                        { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0, 0 }, { 1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1, 1 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, -1 }, { 0, 1, 1, -1, -1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 1 }, { 0, 0, -1, 0, 0, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 1, 0, -1, 0, 0 }, { 0, -1, -1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 1, -1, -1, 1 }, { 0, 0, -1, 1, 1, -1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 0 }, { 0, 1, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, -1, -1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, -1, -2, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 1, 0, 0, 1 }, { 1, 0, -1, 0, 0, -1 }, { 0, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1, 0 }, { -1, 0, -1, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 0, -1 }, { 0, 1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 1, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 0 }, { 1, 1, 0, -1, -1, 0 }, { 0, -1, 0, 1, 0, 0 }, { 1, 1, 0, -1, -1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 1, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 },
                        { 0, 0, 1, 1, 1, 1, -1 }, { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { 0, 0, 1, -1, -1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 2, 0, -2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 2, 0, 0, -1 }, { 1, 0, -2, 1, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, -1, 0, 1, -1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, -2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, -1, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, -1, 0, -1, 0, 0 }, { 1, 0, -1, -1, -1, -1, 1 }, { 1, 0, -1, 0, -1, 0, 0 },
                        { 1, 0, -1, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, -1, -1, -1, -1, 1 }, { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 1, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, -1, 0, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 1, 0, -1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, -1, -2, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, -2, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 1 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, -1, -2, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, -1, -1, -2, -1, -1, 1 }, { -1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 1 }, { -1, 0, 1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, -1, -1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 0, -1 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 0, -1, 0, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    }))
            });
    }

    public static AlgoMeta Build4x6x7Metadata()
    {
        return new AlgoMeta { n = 4, m = 6, p = 7, R = 123, NnzU = 631, NnzV = 842, NnzW = 599 };
    }
}