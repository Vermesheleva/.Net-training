using System;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int? NextBiggerThan(int number)
        {
            if (number == int.MaxValue)
            {
                return null;
            }

            if (number < 0)
            {
                throw new ArgumentException("Number should be >= 0.", nameof(number));
            }

            int maxDigit = 0;
            int count = 1;
            int temp = number;

            while (temp > 10)
            {
                count += 1;
                temp /= 10;
            }

            int[] digits = new int[count];

            for (int j = 0; j < count; j++)
            {
                digits[j] = number % 10;
                number /= 10;

                if (digits[j] > maxDigit && j != count - 1)
                {
                    maxDigit = digits[j];
                }
            }

            if (maxDigit == 0 || count == 1 || digits.All(elem => elem == maxDigit))
            {
                return null;
            }

            if (count == 2)
            {
                return (10 * digits[0]) + digits[1];
            }

            int ind = 0;
            int i = 1;
            bool swap = false;

            if (digits[0] > digits[1])
            {
                (digits[0], digits[1]) = (digits[1], digits[0]);
            }
            else
            {
                while (i < count && !swap)
                {
                    ind = FindNextDigitIndex(i, digits);

                    if (ind != -1)
                    {
                        (digits[i], digits[ind]) = (digits[ind], digits[i]);
                        swap = true;
                    }

                    i++;
                }

                Array.Sort(digits, 0, i - 1, new Comparer());
            }

            int? answer = 0;
            int pow = 1;

            for (int j = 0; j < count; j++)
            {
                answer += digits[j] * pow;
                pow *= 10;
            }

            return answer;
        }

        public static int FindNextDigitIndex(int elemIndex, int[] arr)
        {
            int elem = arr[elemIndex];
            int returnIndex = -1;
            int nextDigit = int.MaxValue;

            for (int i = 0; i < elemIndex; i++)
            {
                if (arr[i] > elem && arr[i] <= nextDigit)
                {
                    returnIndex = i;
                    nextDigit = arr[i];
                }
            }

            return returnIndex;
        }

        public class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return -x.CompareTo(y);
            }
        }
    }
}
