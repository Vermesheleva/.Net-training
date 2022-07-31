using System;

namespace RelocationElements
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[]? source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array is empty.", nameof(source));
            }

            int count = source.Count(elem => elem == value);

            if (count != 0 && count != source.Length && source.Length != 1)
            {
                int found = 0;
                int i = 0;

                while (found != count)
                {
                    if (source[i] == value)
                    {
                        found++;
                        Relocation(source, i, value);
                    }

                    if (source[i] != value)
                    {
                        i++;
                    }
                }
            }
        }

        public static void Relocation(int[] array, int ind, int value)
        {
            for (int i = ind; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = value;
        }
    }
}
