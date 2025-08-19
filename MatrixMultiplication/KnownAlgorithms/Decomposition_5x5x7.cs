namespace MatrixMultiplication.KnownAlgorithms;

public static class Decomposition_5x5x7
{
    public static Formula Build5x5x7Formula()
    {
        return new Formula(5, 5, 7, [
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 2, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 3, 0, -4, -1, -7 }, { 2, 0, -4, -2, -6 }, { -3, 0, 4, 1, 7 }, { 2, 0, -4, -2, -6 },
                    { -1, 0, 0, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, -2 }, { 2, 0, -2, 0, -4 }, { -1, 0, 1, 0, 2 }, { 2, 0, -2, 0, -4 },
                    { 1, 0, -1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 1, 0, 1, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -2, 0, -1, -1, 0 }, { 0, 0, 2, 0, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, -1, -1, -1, -1 }, { 0, 0, 2, 0, 0 }, { 0, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 1, -1, 0, 1, 1, 0 }, { 0, 0, -1, 0, 2, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, -1, 0, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -2, 0, 0, -1 }, { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, -2, 0, 0, -1 }, { 1, 0, 0, 2, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 1, -1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, 0, -1, 0, 1, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, -1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 2, -2, 2, 0, -2 }, { 0, -2, -2, 2, -2, 0, 2 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, -1 }, { 2, 0, 0, 2, -2 }, { -1, 0, 0, -1, 3 }, { 2, 0, 0, 4, -2 }, { 1, 0, 0, 3, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 2, 0, 0, -2 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, -2, 0, 0 }, { -1, 0, 1, 0, 2 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, -1, 0 }, { 0, 0, -1, 0, -1, 0, 0 },
                    { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, -1, 0, -1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, -1, 2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 1, -2 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -2, 0, 2, 0, 0 }, { 1, 0, -1, 0, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, -1, -1, 1 }, { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }, { -1, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, 0, 1, 0, -1, 0 }, { -1, -1, 0, -1, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, -1, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, -1, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, -1, -2, -1, -1, 0, 0 }, { 1, 1, 2, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, -1, 0, 0 }, { 0, 1, 1, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, -1, 1, -1, 0, 1 }, { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 1, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, -2, 0, 0, 4 }, { 0, 0, 0, 0, 0, 0, 0 }, { 4, 0, 0, -4, 0, 0, 4 },
                    { 0, -1, 0, 1, 0, 0, -2 }, { -2, 1, 0, 1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, -4, 0, 0 }, { 0, 0, 1, -1, -1, -1, 2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { -1, -1, 0, -1, 1 }, { 0, 1, 0, 1, 0 }, { -1, -1, 0, -1, 1 },
                    { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -2, 0, -2, -2, 0 }, { 0, 0, 2, 0, 2, 2, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 1, 0, 1, 1 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, -4, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 1, 1, 1, -2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, -1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 1, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0 }, { 0, 1, 0, 1, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 0, -1, 2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0 }, { -1, 1, 0, -1, 1 }, { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, -2 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, -1, 0, 0 }, { -1, 0, 1, 0, 2 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, -3, 0, -2, -2, 0 }, { 0, 0, 3, 0, 2, 2, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, -1, 0, 0, 0 }, { 0, 1, 0, 1, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, -1, -1, 2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 1, -2 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, -1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -2, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -2, 0, 2, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, -1, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 1, 0 }, { 1, 1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, 0, -2, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 1, -1, 0 }, { 0, 1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -1 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, -4, 0, 0 }, { 0, -1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, -4, 0, 0 }, { -1, 0, 1, 0, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, -1, -1 }, { 0, 0, -2, -2, -2 }, { 0, 0, 1, 1, 1 }, { 0, 0, -2, -2, -2 },
                    { 0, 0, -1, -1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 0 }, { 0, 1, 0, 1, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 0, -1, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, -1 }, { 1, 0, 0, 1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -2, 0, -2, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 },
                    { 0, 0, -2, 0, -2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 1, 2, 1, 1, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 1, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0 }, { 0, 1, 0, -1, -1 }, { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -1, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -1 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, 2 }, { -2, 0, 2, 0, 4 }, { 1, 0, -1, 0, -2 }, { -1, 0, 1, 0, 2 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, -1, 0, -1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { -1, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 2, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, 1, 0, -1 }, { 0, 0, 1, 0, 1, 0, 0 },
                    { 0, -1, -1, 1, -1, 0, 1 }, { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, -1, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 1, -1, 1, -1 }, { 0, 1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 0, -2, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, -1, -1, -1, -1 }, { 0, 1, 0, 1, 0 }, { 0, -1, -1, -1, -1 },
                    { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 1, 0, 0, 0 },
                    { 0, 0, 0, -1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -2, 0, 2, 0, 0 }, { 0, 1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 1, 0, -1, -1, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, -2, 1, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 2, -1, 1, 0, -1 }, { 0, -1, -2, 1, -1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 1 }, { 0, -1, 0, -1, 0 }, { 0, 1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, -1 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, -1, -1, -1, 2 }, { 0, 0, 1, 0, -1, 0, 0 },
                    { 0, 0, -1, 1, 1, 1, -2 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 2, 2, 1, 1, 1 }, { 0, 0, 2, 0, 1, 1, 0 },
                    { 0, 0, -2, 0, -1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 },
                    { 0, 1, 2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -2, 0, 2, 0, 0 }, { 0, 0, -1, 1, 1, 1, -2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, -1, -1, -1, 2 }, { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, 0, 2, -2, 2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, -1, 1, -1 }, { 1, 0, 0, 0, 1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -2, 0, -2, 0, 0 }, { 0, 0, 2, 0, 2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { -1, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 2, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -2, 0, -1, -1, 0 }, { 0, 0, 2, 0, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 1, -1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 2, 0, 2, 1, 0 }, { 0, 0, -2, 0, -2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, -2 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -3, 0, -2, -2, 0 }, { 0, 0, 3, 0, 2, 2, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -1, 1 }, { -2, 0, 0, -2, 2 }, { 1, 0, 0, 1, -1 }, { -2, 0, 0, -3, 1 },
                    { -1, 0, 0, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 1, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 1, 0, -1, 0, -2 }, { 0, 0, 2, 0, 0 }, { 0, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { -1, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 1, 0, -3, 0, -1, -2 }, { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, -1, 0, -1, 0, 1, 0 }, { 1, 1, 0, 1, 0, -1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 2 }, { -1, 0, 1, 0, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 1, 0, -3, 0, -1, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 1, 1 }, { 1, 1, -1, 1, -1, -1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, -1, -1, -1 }, { 0, -2, -2, -2, -2 }, { 0, 1, 1, 1, 1 }, { 0, -2, -2, -2, -2 },
                    { 0, -1, -1, -1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, -1 }, { 2, 0, 0, 2, -2 }, { -1, 0, 0, -1, 1 }, { 1, 0, 0, 1, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 1, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, -1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -1, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, -2, 1, -2, 0, 1 }, { 0, 0, 2, 0, 2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, -2, 0, -2, -2 }, { 0, -1, 0, 1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, -1 }, { 2, 0, 0, 2, -2 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, -1, -1, 1, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 3, -2, 2, 0, -2 }, { 0, -2, -3, 2, -2, 0, 2 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, 2 }, { -2, 0, 2, 0, 4 }, { 1, 0, -1, 0, -2 }, { -2, 0, 2, 0, 4 }, { -1, 0, 1, 0, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, -1 }, { 2, 0, 0, 2, -2 }, { 0, 0, 0, 0, 0 }, { 2, 0, -1, 1, -3 }, { 1, 0, -1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, 1, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 1, -1, 0 },
                    { 0, 1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, -1, 1, -1, 0, 1 }, { 0, 0, 1, 0, 0, 0, 0 },
                    { 0, 2, 3, -2, 2, 0, -2 }, { 0, -2, -3, 2, -2, 0, 2 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 0, 1, 0, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, -1 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { -1, -1, 1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 2, 2, -1, 2, -2, 0, 0 }, { -2, -2, 1, -2, 2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, -2 }, { 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, -1, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, -1, 0, -1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { -1, 0, 0, 0, 2 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 0, 0, 0 },
                    { 0, 0, 2, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, 0, -2, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 1, -1, 0 }, { 0, 1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { -1, 0, 0, -1, 1 }, { -1, 0, 0, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, -1, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, -1, -1, -1 },
                    { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, -2, 0, 0, -1 }, { 1, 0, 0, 2, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 0, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 2, 0, 0, 1 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, 0, 1, -1, 1 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, -1 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, -1, 0, -1, 0 }, { 0, 1, 0, 1, 0 }, { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -2, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 1, 0, 0, -1 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, -1 }, { 0, 1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 },
                    { 1, 2, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0 }, { 0, -1, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 2, 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, -1, 0, 0, 0, 0, -1 }, { -1, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, -1, -1 }, { 0, 0, -2, -2, -2 }, { 0, 0, 1, 1, 1 }, { -1, 0, -1, -2, 0 },
                    { -1, 0, 0, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 2, -2, 2, -4 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, 1, -1, 2 }, { 0, 0, 0, 1, -1, 1, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 0, -1, 0, 1, 0 }, { 0, 1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, -2, 0, 0, 2 }, { 1, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 1, 0, 0, -1 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, -1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -1 },
                    { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1 }, { 1, 0, -1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, -1, -1 }, { 0, -1, 0, 1, 0, 1, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, -1, 1, -1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 0 }, { 0, 0, -1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 2, 0, 0 }, { 0, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 0, -1, -1, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                    { 0, 1, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1 }, { 0, 0, 0, -1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 2, -1, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, -2 }, { 1, 0, -1, 0, -2 }, { -1, 0, 1, 0, 2 }, { 1, 0, -1, 0, -2 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, -2, -2, 0 }, { 0, 0, 0, 0, 2, 2, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, 2 }, { -2, 0, 2, 0, 4 }, { -1, 0, 1, 0, 2 }, { -2, 0, 2, 0, 4 }, { -1, 0, 1, 0, 2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, -1, 1, 1, 1, -2 }, { 0, 0, -1, 0, 2, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, -1 }, { 2, 0, 0, 2, -2 }, { -1, 0, 0, -1, 1 }, { 2, 0, -1, 1, -3 },
                    { 1, 0, -1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, -1 }, { 2, 0, 0, 2, -2 }, { 0, 0, 0, 0, 0 }, { 2, 0, 0, 3, -1 }, { 1, 0, 0, 2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 1, 0, 0, 0, 0, 1 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, 0, 2, 0, 0 }, { 0, 0, -1, -1, -1 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 1, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 2, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, -1, 0, 0 }, { -1, -1, 1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, -1, 1, -1, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -2 }, { 1, 0, -1, 0, -2 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 2, 0, 1 }, { 0, 0, -1, 0, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 1, 0, -3, 0, -1, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 1, 1 }, { 1, 1, 0, 1, 0, -1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 2 }, { 0, 0, 0, 0, 1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, -1, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -2, 2, 0, 0, 0, 0, 2 }, { -1, 0, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, -1, 0, 0, 0, 0, -1 }, { -1, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, -2 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, -1, -1, 0 },
                    { 0, 0, -2, 0, -1, -1, 0 }, { 0, 0, 2, 0, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -2, 0 }, { -2, 0, 0, -4, 0 }, { 1, 0, 0, 2, 0 }, { -2, 0, 0, -4, 0 },
                    { -1, 0, 0, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 1, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, -1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 2, 0, 0, 0, 1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, -1 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 1, -1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, -2, 1, -2, 0, 0 }, { 0, 0, 2, 0, 2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 1, 2, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 2, 1, 1, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 1, 0, 1, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0 }, { 0, 1, -1, -1, -1 }, { 0, -1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, -1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, -1, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0 }, { 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 1, 2, -3, 1, 0, -2 }, { 1, 0, 0, 2, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, -1, -2, -1, -1, 0, 0 }, { 1, 1, 2, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, -2, 0, -2, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0 }, { -1, 1, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { -1, 1, 0, 1, 1 }, { 0, 1, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                    { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1 }, { 0, 0, 1, 1, 1 } }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 0, 1 }
                }))
        ]);
    }
    
    public static AlgoMeta Build5x5x7Metadata()
    {
        return new AlgoMeta { n = 5, m = 5, p = 7, R = 127, NnzU = 748, NnzV = 715, NnzW = 782 };
    }
}