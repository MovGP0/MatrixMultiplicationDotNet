namespace MatrixMultiplication.KnownAlgorithms;

public static class Decomposition_4x5x7
{
    public static Formula Build4x5x7Formula()
    {
        return new Formula(4, 5, 7,
        [
            new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 1, 0, 1, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 1 }, { 1, 0, -1, 0, 0 }, { 0, 0, -1, 0, -1 }, { 0, 0, 1, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, -1, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, -1, 1 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, -1, 1, -1 }, { 0, 0, -1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, -1, 1, 1, 1, 0 }, { 0, 1, 0, 0, -1, -1, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 1, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0 }, { 0, -1, -1, 1, -1 }, { 0, 1, 0, 0, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0 }, { -1, 0, 1, 0, 0 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, -1, -1 }, { -1, 0, 1, 0, 0 }, { 0, 0, 1, 1, 1 }, { 0, 0, -1, -1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, -1, 1, 1, 1 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, -1, -1 }, { 0, 0, -1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, -1, 0, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -2, 0, 2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 2, 0, -2, 1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 2, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, -1, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 1, 1, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 1, 0, -1, 1, 0, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 1, -1, 0, -1, -1, 0 }, { -1, -1, 1, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0 }, { 0, 1, 1, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, -1, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1, 0, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 2, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1, 1 },
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, -1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, -1 }, { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -2, 2, 0, 2, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, -2, 2, 0, 2, 2, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 2, -2, 0, -2, -2, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 1, 0, -1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 2, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, -1, 1 },
                        { 0, 0, 0, -1, 0, 0, 1 }, { -1, 0, 0, -1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -2, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 2, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 2, 1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 1, -1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 0, -1, 1, 0 },
                        { 0, -2, -2, 0, -2, 2, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1, 1, -1 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1 }, { 0, 0, 1, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -1, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 1, 0, 1, 1, 0 }, { 1, 2, -2, 0, -2, -2, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { -1, 0, 0, -1, -1 }, { 1, 0, 0, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, -1, -1, -1, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, -1, 1, 1, 1, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                        { 0, 0, -1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { -2, 0, 1, -1, -1 }, { 1, 0, 0, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -2, -2, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0, 0 },
                        { 0, 2, 2, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { -1, 1, 0, -1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 1, 1, 1 }, { 1, 0, -1, 0, 0 }, { 0, 1, -1, -1, -1 }, { 0, -1, 1, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 2, -2, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, -1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 1, -1, 0, 1, 1 }, { 0, -1, 0, 1, 0 }, { -1, 1, 0, -1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 1, 0, 0, -1, -1, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1 }, { -1, 0, 0, -1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, -1, 0, -1, -1, 0 },
                        { -1, -1, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, -1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -1, -1, 0, -1, 0, 0 }, { 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 1, 1, 1, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -1, -1, 0, -1, 0, 0 }, { 1, 1, 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 1, 1, 1, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 4, -1, -1, -3 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1, -1, 1 },
                        { 0, 0, 0, -2, 0, 0, 2 }, { -1, 0, 0, -2, 1, 1, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -2, -1, -1, -1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                        { 0, 3, 1, 1, 1, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 1, 0, 1, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 1, -1, 1, 0, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 0, -1, -1, 1, -1 }, { 0, -1, 0, 1, 0 }, { 0, 1, 1, -1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0 }, { -1, 1, 0, -1, -1 }, { 0, 1, 0, 0, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 },
                        { 0, 0, 0, -1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 },
                        { 0, -2, -1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 1, 1, 1, 0, 1, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 1, 0, 1, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1 }, { 0, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, -1, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 1, 0, 1, 1, 0 },
                        { 0, -1, 1, 0, 1, 1, 0 }, { 1, 2, -2, 0, -2, -2, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 0, 1, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 2, 0, 0, 2, 2 }, { -1, 0, 0, -1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { -1, -1, -1, 0, -1, 0, 0 },
                        { -1, 0, -1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 2, 1, 0, 1, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0 }, { -1, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, -1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 2, 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 0, 0, 0 }, { -1, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, -1, 0, 1, 0, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 1, -1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, -1, 0, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, -1, 0, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 1, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 2, 1, 1, 1, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 1, 1, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, -1, -1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -2, -1, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 2, 1, -1, 1 }, { 0, -2, -1, 1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0, 0 },
                        { 0, 2, 2, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, 0, 0 }, { 0, 1, 1, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 1 },
                        { 0, 0, 0, 0, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -2, -2, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 1, -1, 0, 1, 1 },
                        { 0, 2, 2, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 1, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, -1, 0, -1, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, 1 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, 0, 0, 0, 0, 0 }, { 1, 1, 1, 0, 1, 0, 0 },
                        { 1, -1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { -2, 1, 1, -1, -1 }, { 1, -1, 0, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { -1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -1 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 1, 0, -1, 0, 0 }, { -1, 0, 1, 0, 0 }, { -1, 0, 1, 0, 0 }, { 1, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, 1 }, { 0, 1, -1, -1, -1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 1, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, -1, 1 },
                        { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 1, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 1, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, -1, 0, -1, -1, 0 },
                        { 0, -1, 1, -1, 0, 0, 0 }, { -1, 0, 0, 1, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 1, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { -1, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 0, 1, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 1, 0, -1, 0 }, { 0, -1, 0, 1, -1 }, { 0, -1, 0, 1, 0 }, { 0, 1, 0, -1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 },
                        { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 1, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, -1, -1 }, { 0, 1, -1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, -1, 0, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, -1, 0, -1, -1, 0 }, { 0, -1, 1, 0, 1, 1, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 1, 1, 1, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 1, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { -1, -1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, 1 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, -1, 0, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 1, 0, -1, 0, 1, 1 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { -1, 0, 1, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }
                    })),
                new ProductTerm(
                    Matrix<double>.Build.DenseOfArray(new double[,]
                        { { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 } }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, 0 },
                        { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                    }),
                    Matrix<double>.Build.DenseOfArray(new double[,]
                    {
                        { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0, 1 }, { 1, 1, 1, 0, 1, 0, 0 },
                        { 1, 1, 1, 1, 1, 0, 1 }
                    }))
        ]);
    }

    public static AlgoMeta Build4x5x7Metadata()
    {
        return new AlgoMeta { n = 4, m = 5, p = 7, R = 104, NnzU = 467, NnzV = 621, NnzW = 558 };
    }
}