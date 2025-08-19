namespace MatrixMultiplication.KnownAlgorithms;

public static class Decomposition_4x7x7
{
    public static Formula Build4x7x7Formula()
    {
        return new Formula(4, 7, 7, [
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -2, 0, -2, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 2, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, -1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, 1, -1, -1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, 0 },
                    { 1, 0, 1, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, -1, 0, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 1, 0, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, -1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 1, 1, 1, 1, -1 },
                    { 0, 0, 0, 1, 2, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, -1, 0 }, { 0, 2, 0, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { -1, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 1, 0, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 0, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                    { 0, 1, -1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 1, 0, -2, 0 },
                    { 0, 1, 0, -3, 0, 4, 1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, -2 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { -1, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 2, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 1, 2, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, -1, 1, 1, 1 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 0, -1 }, { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 1 },
                    { -2, 0, -2, 2, -2, -2, -2 }, { 1, 0, 1, -1, 1, 1, 1 }, { 1, 0, 1, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, -1, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 1, 1 },
                    { 0, 0, 0, 2, 0, -2, -2 }, { 0, 0, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, -1 }, { 0, 1, 0, 0, 1, 0, -1 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 0, 1, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -2, 2, -2, -2, -2 }, { 0, 0, 1, -1, 1, 1, 1 }, { 0, 0, 1, -1, 1, 1, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 1 },
                    { 0, 0, 0, -1, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 2, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, -2, 1, 2, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, -1, 1, 1, 1 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 1, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 3, -1, -3, -1, 0, -1 }, { 1, -1, 1, 0, 1, 1, 0 },
                    { -1, 0, -1, 2, -1, -2, -2 }, { 1, -1, 1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, 0, 1, -1, 1 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 1, 0, -2, 0 },
                    { -1, 0, -1, -2, -1, 5, 0 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 2, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, -2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, -1 },
                    { 0, 0, 0, 1, 2, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 2, 0, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, -1, 2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -2, 1, 1, 0 },
                    { 0, -2, -2, 4, -2, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, -2, 1, 1, 1 },
                    { 0, -2, 0, 4, 0, -2, -2 }, { 0, 1, 0, -2, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, -1, 0, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 1, 0, -1, 0, 0, 1 },
                    { 0, -1, 0, 1, 0, 0, -1 }, { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }, { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -2, 0, 4, 1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 0, -1 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, -2, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, 0, 0, -1, 0, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 1, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, 2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 2, 0, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -2, 0, 1, 1 },
                    { 0, -2, 0, 4, 0, -2, -2 }, { 0, 1, 0, -2, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, -1 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, -1, 0, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 2, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, -1, -1, 2, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 1, 1, -1 }, { -1, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 1, 1, 1, -1 },
                    { 0, 0, 0, 1, 1, 1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, 0, 1, -1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 1, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 5, 1, -2, -2, 0 },
                    { 0, 1, 0, 0, 1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 2, -7, 0, 7, 0, 0, 7 }, { -2, 2, -2, 0, -2, -2, 0 },
                    { 2, 2, 0, -2, 0, 0, 2 }, { -2, 1, 0, -1, 0, 0, 1 }, { 0, 1, 0, -1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -2, 0, 1 }, { 1, 0, 0, 0, 0, 0, 1 }, { 0, -1, 0, -1, -2, 0, 1 },
                    { 0, -1, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, -1, -1 }, { 1, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 2, 0, 1, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, -1 }, { -1, 0, 0, 0, 0, 0, -1 }, { -1, 0, 0, 0, 0, 0, -1 },
                    { -1, 0, 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 1, 0, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 2, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 1, -3, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, -1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 2, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, -2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, -2, 1, 1, 1 },
                    { -2, -2, -2, 4, -2, -2, -2 }, { 1, 1, 1, -2, 1, 1, 1 }, { 1, 0, 1, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, -1, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -2, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 0, 1 }, { 1, 0, -1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, 0, 0, -1, 1, 0 },
                    { 0, 1, 0, 0, 1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, -2, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 2, -4, 0, 2, 0, -2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -2, -2, 4, 0, -2, 0, 2 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, -1, -1, -1, 1 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { 0, 1, 0, -2, 0, 2, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 0, 1, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 1, 0, -1 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, -1, -2, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 0, -1 }, { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, 0, -1, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 },
                    { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, -1 }, { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, -1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { -1, 0, -1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, -1, -1, -1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 1, 0, 0, -1 }, { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, -1, 0 },
                    { 0, 1, 0, 0, 1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 3, 0, 2, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 0, -1, 1, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                    { 0, -1, 1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -2, 0, -1, -1 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, -2, 0, 0 },
                    { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -2, 0, -2, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 1, 2, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, -1, -1, 0, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                    { 0, 1, -1, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, 0, -1, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, 0, -1 }, { 1, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, -1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, -1, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, 0 },
                    { 0, 0, 0, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, -1, 1, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, -1 },
                    { 0, 0, 1, 1, 1, 1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                    { -2, 0, -2, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 1, 0 },
                    { 0, 1, 0, 1, 0, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -3, 0, 4, 1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 1, 1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, -1 }, { 1, 0, 0, 1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -2, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, 0, 2, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, -1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, -1, -5, -1, 2, 3, 0 },
                    { 0, -1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 2, -7, 0, 7, 0, 0, 7 }, { -2, 2, -2, 0, -2, -2, 0 },
                    { 2, 1, 0, -1, 0, 0, 1 }, { -2, 1, 0, -1, 0, 0, 1 }, { 0, 1, 0, -1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -2, 0, 2, 2 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 2, -1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, -1, 0, 1 }, { -1, 1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, -1 }, { 0, 0, -1, 0, 1, 0, 0 },
                    { 0, -1, 1, 0, -1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, -1, -2, 0, 1 }, { 1, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, -1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 },
                    { 1, 0, -1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 0 },
                    { 0, 0, 0, 2, 0, -2, 0 }, { 0, 0, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 1, 1, 0 },
                    { 0, 2, 0, 0, -2, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, -2, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, -2, 1, 1, 1 },
                    { -2, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 1, 0, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, 0, 0, -1, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -2, 0, 1 },
                    { 0, -1, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, -1, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -1, -2, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 1, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { -2, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 1 },
                    { -2, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, -1, 0, 0, -1, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -2, 1, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, -1, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 1, 0, -2, 0 },
                    { 0, 0, 0, -2, 0, 4, 1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, -1, 0, 0, -1 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, 0, 0, -1, 1, 0 }, { 0, 1, 0, 1, 2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, -1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, 1, 1 }, { 0, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, -1, 0 }, { 0, 0, -1, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, -1 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, -1 }, { 0, -1, 0, -2, 0, -1, -1 },
                    { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 1 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, -2, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 2, 0, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, -1, 0, 1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 2, 0, 1, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 4, 0, -4, 0, 0, -4 }, { 1, -1, 1, 0, 1, 1, 0 },
                    { -1, 1, 0, -1, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -2, 0, 2, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -2, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0, 1, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 2, 0, -1 }, { 1, 1, 0, 1, 2, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 2, 0, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 1, 2, 0, -1 }, { 0, 1, 0, 1, 2, 0, -1 },
                    { 0, 0, 0, 1, 2, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 2, -1, 2, 1, 1, 0 }, { 1, 0, -1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -2, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, -1, -1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, -1, 0, 2, 0 },
                    { 0, 0, 0, 1, 1, -3, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }, { 2, 2, 2, -4, 2, 2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 1, -2, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, -1, 2, 0, -1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, -1, 0, 0, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 1, -1, 0, 1, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 1, 0, -1, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, -1, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, -1, 0 }, { -1, 0, -1, -1, -1, 2, 0 }, { 0, 0, 0, 0, 0, -1, 0 },
                    { 0, 0, 0, 0, 0, 3, 0 }, { 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, -1, -1 }, { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 2, 0, 2, 0, 1, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -2, 0, 1 },
                    { 0, 0, 0, -1, -2, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -2, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 0, 0, 0 }, { 0, 1, -1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 2, 0, -2, -1 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, -1, -1 }, { 0, -1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0, 1, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, 1, -1, 1, 1, 1 }, { 0, -1, 0, 1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, -1 },
                    { 0, 1, 0, -1, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, -1, 2, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, -2, 0, 1, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 2, 0, -1 },
                    { 0, 0, 0, 1, 2, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -2, 1, -2, -1, -1, 0 }, { 0, 0, 1, 0, -1, 0, 0 },
                    { 0, 2, -1, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, -2, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 1, -1, -1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, -1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, -2, 0 },
                    { 0, 0, 1, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0, 0 }, { 0, 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, -1, 0, -1, 0, -1 }, { -1, 0, -1, 0, -1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, -4, 0, 1, 0, 0 },
                    { 0, -1, 0, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, -1, -1, -1, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -2, 0, 4, 0 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, -1, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, -2, 0, -2, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 2, 0, 2, 1, 1, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, -1, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, -1, 1, 0, -1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 2, 0, -2, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, -2, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, -2, 0, -2, 0, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 2, 0, 1, 1 },
                    { 0, 1, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { -2, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, -1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 1, 0, 0, 1 }, { -1, 1, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 1, 2, 0, -1 }, { 0, 0, 0, 0, 0, 0, -1 },
                    { 0, 0, 0, 1, 2, 0, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 1, -1, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 1, 1, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -2, 0, 0, 2, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 2, 0, 0, -2, -2, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -2, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, -1, -2, -1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 1, -1, -1, -1 }, { 0, 0, 0, 1, 0, -2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 1, 1, -3, 0 }, { 0, 0, 0, -1, 0, 2, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 1, -1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, -1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 2, -1, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 2, -1, -1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, -2, 1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 1, 0, -1, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, -1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, -1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 1, 0, -1, 0, 0, 0, 0 }, { 0, 2, -1, 2, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 1, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 1 },
                    { -1, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { -1, 1, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, -1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, -1, 1, 1, 1 },
                    { 0, 0, 0, 2, 0, -2, -2 }, { 0, 0, 0, -1, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, -1 }, { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, -1, 0, 1, 0, 0 }, { 0, 0, -1, -1, -1, 1, 1 }, { 0, 0, -1, 0, 1, 0, 0 },
                    { 0, 0, -1, -1, -1, 1, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, -1, 0, 0, 0, 0, 1 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, -3, 0, 3, 0, 0, 1 }, { 0, 1, 0, -1, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, -1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, -2, 0 },
                    { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 1, -1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { -1, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0 }
                })),
            new ProductTerm(
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 0 }, { 0, 0, 0, 1, 1, 1, 0 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1 }
                }),
                Matrix<double>.Build.DenseOfArray(new double[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 0 }
                }))
        ]);
    }

    public static AlgoMeta Build4x7x7Metadata()
    {
        return new AlgoMeta { n = 4, m = 7, p = 7, R = 144, NnzU = 796, NnzV = 1197, NnzW = 806 };
    }
}