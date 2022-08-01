using System;

// ReSharper disable InconsistentNaming
namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minInd = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minInd])
                    {
                        minInd = j;
                    }
                }

                if (i != minInd)
                {
                    (array[i], array[minInd]) = (array[minInd], array[i]);
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length > 1)
            {
                Sort(0, array);
            }
        }

        public static int FindMinInd(int startInd, int[] array)
        {
            int minInd = startInd;

            for (int i = startInd + 1; i < array.Length; i++)
            {
                if (array[i] < array[minInd])
                {
                    minInd = i;
                }
            }

            return minInd;
        }

        public static void Sort(int startInd, int[] array)
        {
            int minInd = FindMinInd(startInd, array);

            if (minInd != startInd)
            {
                (array[startInd], array[minInd]) = (array[minInd], array[startInd]);
            }

            if (startInd + 1 < array.Length - 1)
            {
                Sort(startInd + 1, array);
            }
        }
    }
}
