using System;
using System.Globalization;

namespace Anagrams
{
    public class Anagram
    {
        private readonly string sourceWord;

        /// <summary>
        /// Initializes a new instance of the <see cref="Anagram"/> class.
        /// </summary>
        /// <param name="sourceWord">Source word.</param>
        /// <exception cref="ArgumentNullException">Thrown when source word is null.</exception>
        /// <exception cref="ArgumentException">Thrown when  source word is empty.</exception>
        public Anagram(string? sourceWord)
        {
            if (sourceWord is null)
            {
                throw new ArgumentNullException(nameof(sourceWord));
            }

            if (sourceWord.Length == 0)
            {
                throw new ArgumentException("The source word is emrty.");
            }

            this.sourceWord = sourceWord;
        }

        /// <summary>
        /// From the list of possible anagrams selects the correct subset.
        /// </summary>
        /// <param name="candidates">A list of possible anagrams.</param>
        /// <returns>The correct sublist of anagrams.</returns>
        /// <exception cref="ArgumentNullException">Thrown when candidates list is null.</exception>
        public string[] FindAnagrams(string[]? candidates)
        {
            if (candidates is null)
            {
                throw new ArgumentNullException(nameof(candidates));
            }

            List<string> result = new List<string>();

            foreach (string candidate in candidates)
            {
                bool found = true;
                for (int i = 0; i < this.sourceWord.Length; i++)
                {
                    if (!this.ContainsLetter(candidate, this.sourceWord[i]))
                    {
                        found = false;
                        break;
                    }
                }

                if (found && !candidate.Equals(this.sourceWord, StringComparison.OrdinalIgnoreCase) && !candidate.Contains(this.sourceWord, StringComparison.InvariantCultureIgnoreCase))
                {
                    result.Add(candidate);
                }
            }

            return result.ToArray();
        }

        public bool ContainsLetter(string candidate, char letter)
        {
            candidate = candidate.ToUpper(CultureInfo.InvariantCulture);
            letter = char.ToUpper(letter, CultureInfo.InvariantCulture);
            string source = this.sourceWord.ToUpper(CultureInfo.InvariantCulture);

            int countInSource = source.Count(ch => ch.Equals(letter));
            int countInCandidate = candidate.Count(ch => ch.Equals(letter));

            if (countInCandidate == countInSource)
            {
                return true;
            }

            return false;
        }
    }
}
