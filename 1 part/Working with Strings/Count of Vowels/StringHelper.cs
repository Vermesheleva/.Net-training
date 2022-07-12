using System;

namespace VowelCountTask
{
    public static class StringHelper
    {
        /// <summary>
        /// Calculates the count of vowels in the source string.
        ///  'a', 'e', 'i', 'o', and 'u' are vowels.
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Count of vowels in the given string.</returns>
        /// <exception cref="ArgumentException">Thrown when source string is null or empty.</exception>
        public static int GetCountOfVowel(string source)
        {
            if (source is null || source.Length == 0)
            {
                throw new ArgumentException("String cannot be empty or null.", nameof(source));
            }

            char[] volwels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            for (int i = 0; i < source.Length; i++)
            {
                for (int j = 0; j < volwels.Length; j++)
                {
                    if (volwels[j] == source[i])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
