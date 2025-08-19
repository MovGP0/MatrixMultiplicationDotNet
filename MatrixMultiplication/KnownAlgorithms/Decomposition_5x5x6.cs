namespace MatrixMultiplication.KnownAlgorithms;

public static class Decomposition_5x5x6
{
    public static Formula Build5x5x6Formula()
    {
        return new Formula(5, 5, 6, [
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 4, 4, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, -2, 4, 2, 0, 0 }, { -1, 0, -2, -2, 0, 0 },
                    { 1, -1, 2, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, -1, 0 }, { -1, 0, 0, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, -1, 1 }, { 0, 0, 2, 2, -2 }, { 0, 0, 1, 1, -1 }, { 0, 0, -2, -2, 2 },
                    { 0, 0, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 1, 0, -1, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 1, -1, 0, 1, 1 }, { 0, -1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, -4, -4, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, -4, -4, 2, 0 }, { 1, 0, 2, 2, 0, 0 },
                    { -1, 0, -2, -2, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, -2 }, { 2, 0, -2, 0, 4 }, { 1, 0, -1, 0, 2 }, { -3, 0, 3, 0, -6 },
                    { -2, 0, 2, 0, -4 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 2, 1, 2, 0, 1 }, { 0, -1, 0, -1, 1, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0 }, { 0, -3, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 3, 0, 0, 0 }, { 0, 2, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 1, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { -1, 0, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, -2 }, { 2, 0, -2, 0, 4 }, { 1, 0, -1, 0, 2 }, { -2, 0, 2, 0, -4 },
                    { -1, 0, 1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -2, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, -1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 1 }, { 0, 0, -2, 0, -2 }, { 0, 0, 0, 0, -1 }, { 0, 0, 2, 0, 2 }, { 0, 0, 0, 0, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, 2, -2 }, { 0, 4, 0, -4, 4 }, { 0, 1, 0, -1, 1 }, { 0, -4, 0, 4, -4 },
                    { 0, -2, 0, 2, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, -1 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, -1, 2, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 0, 3, 0, -1, 1 }, { 0, 1, 0, 0, 0 }, { 0, -3, 0, 0, 0 }, { 0, -2, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 1, 0, 0, 0 }, { 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, -2, 1, 0 }, { 0, 0, -1, 0, 0, -1 }, { -1, 0, 0, -2, 1, 1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, -2, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 2, -1, 0 },
                    { -1, 0, -1, -2, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, -1, 1 }, { -1, 0, 3, 2, -4 }, { 0, 0, 1, 1, -1 }, { 1, 0, -3, -2, 4 },
                    { 1, 0, -2, -1, 3 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -2, 2, 0 }, { 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -2, 0, 0, -2 }, { -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 1 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 2, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -2, -2, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, -2 }, { 0, 0, 0, 0, 0, 1 }, { -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 0, 0 }, { 0, 0, 0, 0, 0, 2 }, { -1, 0, -2, -2, 0, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 2, -2 }, { 0, 0, 0, -4, 4 }, { 0, 0, 0, -1, 1 }, { 0, 0, 0, 4, -4 }, { 0, 0, 0, 2, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 1, 0, -1, 0, 0 }, { 0, -1, -1, 1, 1, 1 }, { 2, 1, 0, -1, 0, 0 }, { 0, -1, -1, 1, 1, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, -1, -2, 2 }, { 0, -4, 2, 4, -4 }, { 0, -1, 1, 1, -1 }, { 0, 4, -3, -4, 4 },
                    { 0, 2, -2, -2, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0 }, { 0, -1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -2, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 1 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, -4, -4, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { -1, 3, 0, -1, -1 }, { 0, 1, 0, 0, 0 }, { 0, -3, 0, 0, 0 }, { 0, -2, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { -1, 0, -2, -2, 1, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0 }, { 0, 3, 0, -2, 0 }, { 0, 1, 0, -1, 0 }, { 0, -3, 0, 2, 0 }, { 0, -2, 0, 2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 1, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 2 }, { -2, 0, 0, 0, -3 }, { 0, 0, 0, 0, 0 }, { 2, 0, 0, 0, 3 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -2, 2, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -2, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 1, 1, 0 },
                    { -1, 0, 0, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 4 }, { -4, 0, 3, 0, -8 }, { -1, 0, 1, 0, -2 }, { 4, 0, -3, 0, 8 }, { 2, 0, -2, 0, 4 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -2, 2, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, -2, 2 }, { 0, 0, 3, 4, -4 }, { 0, 0, 1, 1, -1 }, { 0, 0, -3, -4, 4 },
                    { 0, 0, -2, -2, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 2 }, { -2, 0, 0, 0, -4 }, { 0, 0, 0, 0, 0 }, { 2, 0, 0, 0, 4 }, { 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -2, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, -4, -4, 2, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, -1, 0 }, { 2, 1, 0, -1, 0, 0 }, { -2, 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, -1, 0, 0 },
                    { 1, 0, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, -2, 1, 0 }, { 1, 0, 1, 2, -1, 0 }, { -2, 0, -2, -4, 2, 0 }, { 1, 0, 1, 2, -1, 0 },
                    { -1, 0, -1, -2, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -1, -1 }, { 2, 0, 0, 2, 2 }, { 1, 0, 0, 1, 1 }, { -2, 0, -1, -3, -1 },
                    { -1, 0, -1, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 4, 4, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, 0, 4, 2, 0, 0 }, { -1, 0, -2, -2, 0, 0 },
                    { 1, 0, 2, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 0 }, { 0, -3, 0, 3, -1 }, { 0, -1, 0, 1, 0 }, { 0, 3, 0, -3, 1 }, { 0, 2, 0, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 1, 0, -4 }, { 5, 1, -2, 1, 9 }, { 1, 0, -1, 0, 2 }, { -5, -1, 2, -1, -9 },
                    { -2, 0, 2, 0, -4 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -2, 2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 1, -1, 0 },
                    { 0, 0, 0, -1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0 }, { 0, -3, 1, 1, -1 }, { 0, -1, 0, 0, 0 }, { 0, 3, 0, 0, 0 }, { 0, 2, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, -2 }, { 2, 0, 0, 0, 4 }, { 0, 0, 0, 0, 0 }, { -2, 0, 0, 0, -3 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 1, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 1 }, { -2, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0 }, { 2, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 2, 2, -1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, -1, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { -1, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, -2, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 2, -1, 0 },
                    { -1, 0, -1, -2, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 0, -1, -1 }, { -1, 0, 0, -1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, -4, -4, 2, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -2, -2, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, -2 }, { -1, 0, 1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 2, 2, 2, 0, 2 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 1, 1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, 0 }, { 0, 0, -4, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 4, 0, 0 }, { 0, 0, 2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, -2, 2, 2, 0, 0 }, { 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0 }, { 0, 3, -1, -3, 1 }, { 0, 1, 0, -1, 0 }, { 0, -3, 1, 3, -1 }, { 0, -2, 0, 2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 1 }, { 0, 0, 0, 2, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 4, 2, 0, -2, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 1, 1, 0 },
                    { -2, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -2, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, -4, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 1, 1, -2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 1, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, 2, 0, 0 }, { -1, 1, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 0, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, -1, 1 }, { 0, 0, 2, 2, -2 }, { 0, 0, 1, 1, -1 }, { 1, 0, -3, -2, 4 },
                    { 1, 0, -2, -1, 3 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, -1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 2, 1, 2, 0, 1 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 2, -2 }, { 0, 0, -2, -4, 4 }, { 0, 0, -1, -1, 1 }, { 0, 0, 3, 4, -4 }, { 0, 0, 2, 2, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, -1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { -2, -1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 4, 0, -2, -2, -2, -2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 1, 1, 1, 1 },
                    { -2, 0, 1, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, 0 }, { 1, -1, 2, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, 2, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, -1, 2, 2, 0, 0 }, { 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1 }, { 0, -1, 0, 1, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -2, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 1, 1, 0 },
                    { -1, 0, 0, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 2, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, -2 }, { 2, 0, -2, 0, 4 }, { 1, 0, -1, 0, 2 }, { -2, 0, 2, 0, -4 },
                    { -1, 0, 1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, -1, 0, 0, 1, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 0 }, { 0, -2, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 2, 0, -2, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 1, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 1, -2, -1, 0, -1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, -1 }, { 0, 2, 0, -2, 2 }, { 0, 0, 0, 0, 0 }, { 0, -2, 0, 2, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, -2 }, { 0, 2, 0, -2, 4 }, { 0, 0, 0, 0, 1 }, { 0, -2, 0, 2, -4 }, { 0, 0, 0, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, 0, 0, 0 }, { 0, 1, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 1, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1 }, { 0, 0, 0, -2, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 4, 2, 0, -2, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { -2, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, -1 }, { 0, -1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 4, 4, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 2, 0, 0, 0 }, { -1, 0, -2, -2, 0, 0 },
                    { 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 0 }, { -1, -1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 1, 1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 3, 2, -1, 2 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, -1, 1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, -2 }, { 2, -1, 0, 0, 4 }, { 0, 0, 0, 0, 0 }, { -2, 1, 0, 0, -4 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, -1, 0 },
                    { 0, 0, 0, -1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0 }, { 0, 0, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 4, 2, 0, -2, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 },
                    { -2, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 2, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 1 }, { 0, 0, 0, 2, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, -2, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 4, 2, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, 0 }, { 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 0, 1, -1, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, -1 }, { 0, 0, 1, 0, 0, 1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, -1, 0, 0 }, { 0, 0, -1, 0, 0, -1 }, { -1, 0, 0, -1, 0, 1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, -1 }, { 0, -1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 4, 4, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2 }, { -1, 0, -2, -2, 0, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, -3 }, { 2, 0, 0, 0, 6 }, { 0, 0, 0, 0, 1 }, { -2, 0, 0, 0, -6 }, { 0, 0, 0, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 1, 0, -2, -1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 1, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, 1 }, { 0, 0, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 4 }, { -4, 0, 2, 0, -8 }, { -1, 0, 1, 0, -2 }, { 4, 0, -2, 0, 8 }, { 2, 0, -1, 0, 4 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 2, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, 1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, -2, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, -2, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 1, 2, -2 }, { 0, 4, -2, -4, 4 }, { 0, 1, -1, -1, 1 }, { 0, -4, 2, 4, -4 },
                    { 0, -2, 1, 2, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0 }, { 1, 1, 0, -1, -1, 0 }, { 0, -1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 2, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 1, 0, 0 }, { -1, 1, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 1, -2, -1, 0, 1 },
                    { 0, -1, 0, -1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, 1 }, { -2, 0, 0, -2, -2 }, { -1, 0, 0, -1, -1 }, { 3, 0, 0, 3, 3 }, { 2, 0, 0, 2, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 1, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 0 }, { 0, -2, 0, 2, 0 }, { 0, -1, 0, 1, 0 }, { 0, 2, 0, -2, 0 }, { 0, 2, 0, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { -1, 1, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1 }, { 0, 0, 2, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 2 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0 }, { 0, 1, 1, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 0, 0, -4 }, { 4, 0, 0, 0, 8 }, { 1, 0, 0, 0, 2 }, { -4, 0, 0, 0, -8 }, { -2, 0, 0, 0, -4 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 0, 0 }, { 2, 0, 4, 2, 0, 0 }, { -1, 0, -2, -2, 0, 0 },
                    { 1, 0, 2, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 1 }, { 0, -2, 0, 2, -2 }, { 0, 0, 0, 0, 0 }, { 0, 2, 0, -2, 2 }, { 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, 0, 0, 0 }, { 1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -2, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 2, -4, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 2, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -1, -1 }, { 2, 0, 0, 2, 2 }, { 1, 0, 0, 1, 1 }, { -2, 0, 0, -3, -1 },
                    { -1, 0, 0, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 0, 0 }, { 0, 0, 2, 0, 0, 0 }, { -1, 0, -2, -2, 0, 0 },
                    { 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -2, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, 2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 1, 1, -2 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 1, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 0, 1 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 1, 1, -1 }, { 0, 2, -2, -2, 2 }, { 0, 1, -1, -1, 1 }, { 0, -2, 2, 2, -2 },
                    { 0, -1, 1, 1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 2 }, { 1, 0, -1, 0, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, -1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 0 }, { 1, -3, 0, 3, 1 }, { 0, -1, 0, 1, 0 }, { -1, 3, 0, -3, -1 }, { 0, 2, 0, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -2, 1, 1 }, { 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, -1, 0 }, { 0, -2, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 2, 0, -2, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, -1, 2, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 1, -1, 2, 1, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -2 }, { 0, 0, 0, -2, 4 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 2, -4 }, { 0, 0, 0, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 4, 2, 0, -2, 0, 0 }, { 0, -1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 1 },
                    { -2, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, -4 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 4 }, { 0, 0, 0, 0, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, -2, -2, -2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 1 },
                    { 0, 0, -1, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, -1, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, 1 }, { -2, 0, 0, -2, -2 }, { -1, 0, 0, -1, -1 }, { 2, 0, 0, 2, 2 }, { 1, 0, 0, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, -2 }, { 0, 1, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 2, -2, 0 }, { 0, 1, 0, 1, -1, 0 }, { 0, -2, -1, 0, 0, 1 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, -1, 0, 0 },
                    { 1, 0, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, -1, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 2, 2, 0, 0 }, { 1, -1, 1, 1, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 1, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { -2, 0, 1, 0, 0, 0 }, { 0, 0, -1, 1, 1, 0 }, { -2, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 2, -4, -2, 0, 2 }, { -1, 1, -2, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -2, -2, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 1, 1, 0 },
                    { -1, 0, 0, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, -4, 2, -2, 0, 0 }, { 1, -2, 2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { -1, -1, -2, -1, -1 }, { 0, 0, 0, 0, 0 }, { 1, 1, 2, 1, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 1, 0 }, { -1, 0, -1, -1, 0, 0 },
                    { 1, 0, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 1, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 2, 0, 0 }, { -2, 0, -4, -4, 2, 0 }, { 1, 0, 2, 2, 0, 0 },
                    { -1, 0, -2, -2, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 2, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { -2, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0 }, { 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, -1, 1, 1, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0 }, { 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 2, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 3, 1, 0, 2 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 2, 1, 0, 1 }, { 0, 0, -1, 0, 0, -1 },
                    { 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 2, -2 }, { 0, 0, -2, -4, 4 }, { 0, 0, -1, -1, 1 }, { 0, 0, 2, 4, -4 }, { 0, 0, 1, 2, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 1, 0, -1, 0, 0 }, { -1, -1, 0, 1, 1, 0 }, { 2, 1, 0, -1, 0, 0 }, { -1, -1, 0, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -1, 0, -2, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 1, 0, -4 }, { 4, 0, -2, 0, 8 }, { 1, 0, -1, 0, 2 }, { -4, 0, 3, 0, -8 },
                    { -2, 0, 2, 0, -4 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 1, 0, 1, 0, 0 }, { 0, -1, 0, -1, 1, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, 1 }, { -2, 0, 0, -2, -2 }, { -1, 0, 0, -1, -1 }, { 2, 0, 0, 2, 2 }, { 1, 0, 0, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, -1, 1, 0, -2 }, { 0, 1, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -2, 2, 0 }, { 0, -1, 0, -1, 1, 0 }, { 0, 2, 1, 0, 0, 1 }, { 0, -1, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, 1, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, 2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 1, -1, 1, 1, 0, 0 }, { 0, 1, 0, 1, 0, 0 }, { 1, -1, 1, 1, 0, 0 },
                    { 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 1 }, { 1, 0, 0, 1, 1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 }, { 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 1 }
                }))
        ]);
    }

    public static AlgoMeta Build5x5x6Metadata()
    {
        return new AlgoMeta { n = 5, m = 5, p = 6, R = 110, NnzU = 859, NnzV = 672, NnzW = 794 };
    }
}