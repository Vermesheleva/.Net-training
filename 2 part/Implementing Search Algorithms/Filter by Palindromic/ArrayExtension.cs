using System;

namespace FilterByPalindromicTask
{
    /// <summary>
    /// Provides static method for working with integers array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns new array that contains only palindromic numbers from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of elements that are palindromic numbers.</returns>
        /// <exception cref="ArgumentNullException">Throw when array is null.</exception>
        /// <exception cref="ArgumentException">Throw when array is empty.</exception>
        /// <example>
        /// {12345, 1111111112, 987654, 56, 1111111, -1111, 1, 1233321, 70, 15, 123454321}  => { 1111111, 123321, 123454321 }
        /// {56, -1111111112, 987654, 56, 890, -1111, 543, 1233}  => {  }.
        /// </example>
        public static int[] FilterByPalindromic(int[]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array is empty.");
            }

            List<int> result = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (IsPalindromic(source[i]))
                {
                    result.Add(source[i]);
                }
            }

            return result.ToArray();
        }

        public static bool IsPalindromic(int number)
        {
            if (number < 0)
            {
                return false;
            }

            int numOfDigits = 0;
            List<int> list = new List<int>();

            while (number > 0)
            {
                numOfDigits++;
                list.Add(number % 10);
                number /= 10;
            }

            int digitFromTheBeginning;
            int digitFromTheEnd;
            int[] digits = list.ToArray();

            for (int i = 0;  i < numOfDigits / 2; i++)
            {
                digitFromTheBeginning = digits[^(i + 1)];
                digitFromTheEnd = digits[i];

                if (digitFromTheBeginning != digitFromTheEnd)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
