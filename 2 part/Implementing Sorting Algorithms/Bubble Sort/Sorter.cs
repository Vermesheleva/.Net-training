using System;

// ReSharper disable InconsistentNaming
namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            bool swap = true;

            while (swap)
            {
                swap = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        swap = true;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length > 1)
            {
                Sort(array, array.Length - 1);
            }
        }

        public static void Sort(int[] array, int endInd)
        {
            if (endInd == 0)
            {
                return;
            }

            int swapCount = 0;

            for (int i = 0; i < endInd; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    swapCount++;
                }
            }

            if (swapCount == 0)
            {
                return;
            }

            Sort(array, endInd - 1);
        }
    }
}
