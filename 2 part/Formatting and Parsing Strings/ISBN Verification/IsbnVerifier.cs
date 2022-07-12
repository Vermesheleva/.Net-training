using System;
using System.Globalization;

namespace IsbnVerification
{
    public static class IsbnVerifier
    {
        /// <summary>
        /// Verifies if the string representation of number is a valid ISBN-10 identification number of book.
        /// </summary>
        /// <param name="number">The string representation of book's number.</param>
        /// <returns>true if number is a valid ISBN-10 identification number of book, false otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if number is null or empty or whitespace.</exception>
        public static bool IsValid(string number)
        {
            if (number is null || number.Length == 0 || number.All(c => char.IsWhiteSpace(c)))
            {
                throw new ArgumentException("Number cannot be null or empty or whitespace.", nameof(number));
            }

            if (number.Length > 13 || number.Length < 10)
            {
                return false;
            }

            int checkSum = 0;
            if (char.IsDigit(number[0]))
            {
                checkSum += 10 * Convert.ToInt32(number[0].ToString(), CultureInfo.InvariantCulture);
            }

            int factor = 9;
            for (int i = 1; i < number.Length - 1; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    checkSum += factor * Convert.ToInt32(number[i].ToString(), CultureInfo.InvariantCulture);
                    factor--;
                }
                else if (!(number[i] == '-' && (i == 1 || i == 5 || i == 11)))
                {
                    return false;
                }
            }

            if (char.IsDigit(number[^1]))
            {
                checkSum += Convert.ToInt32(number[^1].ToString(), CultureInfo.InvariantCulture);
            }
            else if (number[^1] == 'X')
            {
                checkSum += 10;
            }

            if (checkSum % 11 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
