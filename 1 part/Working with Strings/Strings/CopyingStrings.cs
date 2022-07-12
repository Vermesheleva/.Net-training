using System;

namespace Strings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies all ccharacters from the <paramref name="source"/> to the 4th position of the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the beginning of the <paramref name="source"/> to the beginning of the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 0, 3);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies five characters from the beginning of the <paramref name="source"/> to the 4th position of the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, 5);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies six characters from the 2nd position of the <paramref name="source"/> to the 5th position of the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(2, destinationArray, 5, 6);

            return new string(destinationArray);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            char[] templateArray = template.ToCharArray();

            regionCode.CopyTo(1, templateArray, 0, 1);
            locationCode.CopyTo(4, templateArray, 3, 2);
            dateCode.CopyTo(3, templateArray, 7, 3);
            factoryCode.CopyTo(2, templateArray, 12, 4);

            return new string(templateArray);
        }
    }
}
