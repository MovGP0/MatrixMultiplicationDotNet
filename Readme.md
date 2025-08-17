# Matrix Multiplication

Example implementations for matrix multiplication algorithms in .NET

> [!CAUTION]
> This repository is for educational purposes only.
> The code here is untested and unfinished and contain bugs and inefficiencies.
> It is not intended for production use.

## Implemented Algorithms

- ✅ 2×2 Matrices – Strassen’s Algorithm
- ✅ 3×3 Matrices – Laderman’s Algorithm
- ✅ 4×4 Matrices – AlphaTensor
- ✅ 5×5 Matrices – AlphaTensor

## TODO: general

- Implement unit tests for all algorithms.
- Implement benchmarking for all algorithms.
- Implement multiplication of larger matrices using the implemented algorithms.

## TODO: file formats

- Add Support for the **savetensor** file format using [SafeTensorSharp](https://github.com/JohnMasen/SafeTensorSharp)
- Add support for the **pickle** file format using [Pickle](https://github.com/irmen/pickle)
- Convert the json files to a more efficient binary format.
- Render the matrices as human-readable math formulas for verification.

## TODO: algorithms

#### Rectangular Matrices – AlphaTensor Discoveries

* **Implementations:** Various improved algorithms for rectangular matrices (e.g., 3×4 × 4×5) are included in [DeepMind's AlphaTensor GitHub Repository](https://github.com/google-deepmind/alphatensor).

#### Other Algorithms

- TODO

### Further Notes

- Some Algorithms may be able to multiply sub-matrices in order to speed up the multiplication of larger matrices.

[1]: https://www.programmersought.com/article/48127613157/ "C++ implementation of Strassen matrix multiplication - Programmer Sought"
[2]: https://github.com/OsmanMalik/random-approximate-matrix-multiplication/blob/master/mat_mult_laderman.m "random-approximate-matrix-multiplication/mat_mult_laderman.m at ..."
[3]: https://github.com/google-deepmind/alphatensor "google-deepmind/alphatensor - GitHub"
[4]: https://github.com/PhialsBasement/AlphaEvolve-MatrixMul-Verification "PhialsBasement/AlphaEvolve-MatrixMul-Verification - GitHub"
