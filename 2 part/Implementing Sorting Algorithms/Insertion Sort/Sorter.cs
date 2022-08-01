using System;

// ReSharper disable InconsistentNaming
namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] < temp)
                    {
                        break;
                    }

                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length > 0)
            {
                Sort(array, array.Length - 1);
            }
        }

        public static void Sort(int[] array, int endInd)
        {
            if (endInd > 0)
            {
                Sort(array, endInd - 1);
            }

            int temp = array[endInd];

            for (int j = endInd - 1; j >= 0; j--)
            {
                if (array[j] < temp)
                {
                    break;
                }

                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
}
