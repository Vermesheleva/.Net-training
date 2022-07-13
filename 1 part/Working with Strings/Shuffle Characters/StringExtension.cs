using System;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        /// <summary>
        /// Shuffles characters in source string according some rule.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="count">The count of iterations.</param>
        /// <returns>Result string.</returns>
        /// <exception cref="ArgumentNullException">Source string is null.</exception>
        /// <exception cref="ArgumentException">Source string is empty or a white space.</exception>
        /// <exception cref="ArgumentException">Count of iterations is less than 0.</exception>
        public static string ShuffleChars(string? source, int count)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0 || source.All(elem => char.IsWhiteSpace(elem) || char.IsControl(elem)))
            {
                throw new ArgumentException("Source string is empty or a whitespace.", nameof(source));
            }

            if (count < 0)
            {
                throw new ArgumentException("Count of iterations is less than 0.", nameof(count));
            }

            if (source.Length == 1 || source.Length == 2)
            {
                return source;
            }

            int repeat = 1;
            string shuffledString = Shuffle(source);

            while (shuffledString != source)
            {
                shuffledString = Shuffle(shuffledString);
                repeat++;
            }

            if (count % repeat == 0)
            {
                return source;
            }
            else
            {
                count %= repeat;
            }

            while (count > 0)
            {
                source = Shuffle(source);
                count--;
            }

            return source;
        }

        public static string Shuffle(string str)
        {
            char[] result = new char[str.Length];
            int i = 1;
            int pos = str.Length / 2;
            if (str.Length % 2 != 0)
            {
                pos++;
            }

            int j = 1;
            result[0] = str[0];

            while (i < str.Length)
            {
                if ((i + 1) % 2 == 0)
                {
                    result[pos] = str[i];
                    pos++;
                }
                else
                {
                    result[j] = str[i];
                    j++;
                }

                i++;
            }

            return new string(result);
        }
    }
}
