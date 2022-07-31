using System;

namespace SpiralMatrix
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException($"Size of matrix '{size}' cannot be less or equal zero.");
            }

            int[,] matrix = new int[size, size];

            int elem = 1;
            int lastElem = size * size;
            int iter = 0;

            while (elem <= lastElem)
            {
                for (int i = iter; i < size; i++)
                {
                    matrix[iter, i] = elem;
                    elem++;
                }

                for (int i = iter + 1; i < size; i++)
                {
                    matrix[i, size - 1] = elem;
                    elem++;
                }

                for (int i = size - 2; i >= iter; i--)
                {
                    matrix[size - 1, i] = elem;
                    elem++;
                }

                for (int i = size - 2; i > iter; i--)
                {
                    matrix[i, iter] = elem;
                    elem++;
                }

                iter++;
                size--;
            }

            return matrix;
        }
    }
}
