# Matrix Multiplication

Example implementations for matrix multiplication algorithms in .NET

> [!CAUTION]
> This repository is for educational purposes only.
> The code here is untested and unfinished and contain bugs and inefficiencies.
> It is not intended for production use.

## Implemented Algorithms

**Strassen’s Algorithm**
- ✅ 2×2×2 Matrices

**Laderman’s Algorithm**
- ✅ 3×3×3 Matrices

**AlphaTensor**
- ✅ 2×2×2
- ✅ 2×2×3
- ✅ 2×2×4
- ✅ 2×2×5
- ✅ 2×2×6
- ✅ 2×2×7
- ✅ 2×2×8
- ✅ 2×3×3
- ✅ 2×3×4
- ✅ 2×3×5
- ✅ 2×4×4
- ✅ 2×4×5
- ✅ 2×5×5
- ✅ 3×3×3
- ✅ 3×3×4
- ✅ 3×3×5
- ✅ 3×4×4
- ✅ 3×4×5
- ✅ 3×4×11
- ✅ 3×5×5
- ✅ 3×5×9
- ✅ 3×9×11
- ✅ 4×4×4
- ✅ 4×4×5
- ✅ 4×5×5
- ✅ 4×5×9
- ✅ 4×5×10
- ✅ 4×5×11
- ✅ 4×9×10
- ✅ 4×9×11
- ✅ 4×11×11
- ✅ 4×11×12
- ✅ 5×5×5
- ✅ 5×5×7
- ✅ 5×7×9
- ✅ 5×7×10
- ✅ 5×7×11
- ✅ 5×8×9
- ✅ 5×8×10
- ✅ 5×8×11
- ✅ 5×9×9
- ✅ 5×9×10
- ✅ 5×9×11
- ✅ 5×9×12
- ✅ 6×7×9
- ✅ 6×7×10
- ✅ 6×7×11
- ✅ 6×8×10
- ✅ 6×8×11
- ✅ 6×9×9
- ✅ 6×9×10
- ✅ 6×9×11
- ✅ 7×7×9
- ✅ 7×7×10
- ✅ 7×7×11
- ✅ 7×8×9
- ✅ 7×8×10
- ✅ 7×8×11
- ✅ 7×8×12
- ✅ 7×9×9
- ✅ 7×9×10
- ✅ 7×9×11
- ✅ 7×9×12
- ✅ 7×10×10
- ✅ 7×10×11
- ✅ 7×11×11
- ✅ 8×8×10
- ✅ 8×8×11
- ✅ 8×9×10
- ✅ 8×9×11
- ✅ 8×9×12
- ✅ 8×10×10
- ✅ 8×10×11
- ✅ 8×10×12
- ✅ 8×11×11
- ✅ 8×11×12
- ✅ 9×9×9
- ✅ 9×9×10
- ✅ 9×9×11
- ✅ 9×10×10
- ✅ 9×10×11
- ✅ 9×10×12
- ✅ 9×11×11
- ✅ 9×11×12
- ✅ 10×10×10
- ✅ 10×10×11
- ✅ 10×10×12
- ✅ 10×11×11
- ✅ 10×11×12
- ✅ 10×12×12
- ✅ 11×11×11
- ✅ 11×11×12
- ✅ 11×12×12
- General Matrix Multiplication (GeMM) of arbitrary matrices using the AlphaTensor algorithms.

**Reference Decompositions**
- ✅ 4×5×7
- ✅ 4×6×6
- ✅ 4×6×7
- ✅ 4×7×7
- ✅ 5×5×6
- ✅ 5×5×7

## TODO: general

- ⚠️ Code Cleanup
- ⚠️ Add support for reference decompositions to GeMM implementation.
- 💡 Implement benchmarking for all algorithms.

## TODO: file formats

- Add Support for the **savetensor** file format using [SafeTensorSharp](https://github.com/JohnMasen/SafeTensorSharp)
- Add support for the **pickle** file format using [Pickle](https://github.com/irmen/pickle)
- Convert the json files to a more efficient binary format.
- Render the matrices as human-readable math formulas for verification.
