using System;

namespace NumeralSystems
{
    /// <summary>
    /// Converts a string representations of a numbers to its integer equivalent.
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// Converts the string representation of a positive number in the octal numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the octal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-octal alphabetic characters).
        /// Valid octal alphabetic characters: 0,1,2,3,4,5,6,7.
        /// </exception>
        public static int ParsePositiveFromOctal(this string source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            uint result = 0u;
            uint systemBase = 1u;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(source[i]) || source[i] > '7')
                {
                    throw new ArgumentException($"{nameof(source)} does not represent a number in octal numeral system.");
                }

                result += systemBase * ParseCharToUint(source[i]);
                systemBase *= 8u;
            }

            if (result > int.MaxValue)
            {
                throw new ArgumentException($"{nameof(source)} does not represent a positive number in the octal numeral system.");
            }

            return (int)result;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the decimal numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the decimal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-decimal alphabetic characters).
        /// Valid decimal alphabetic characters: 0,1,2,3,4,5,6,7,8,9.
        /// </exception>
        public static int ParsePositiveFromDecimal(this string source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            uint result = 0u;
            uint systemBase = 1u;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(source[i]) || source[i] > '9')
                {
                    throw new ArgumentException($"{nameof(source)} does not represent a number in decimal numeral system.");
                }

                result += systemBase * ParseCharToUint(source[i]);
                systemBase *= 10u;
            }

            if (result > int.MaxValue)
            {
                throw new ArgumentException($"{nameof(source)} does not represent a positive number in the decimal numeral system.");
            }

            return (int)result;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the hex numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid symbols (non-hex alphabetic characters).
        /// Valid hex alphabetic characters: 0,1,2,3,4,5,6,7,8,9,A(or a),B(or b),C(or c),D(or d),E(or e),F(or f).
        /// </exception>
        public static int ParsePositiveFromHex(this string source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            uint result = 0u;
            uint systemBase = 1u;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(source[i]) && !(source[i] >= 'A' && source[i] <= 'F') && !(source[i] >= 'a' && source[i] <= 'f'))
                {
                    throw new ArgumentException($"{nameof(source)} does not represent a number in hex numeral system.");
                }

                result += systemBase * ParseCharToUint(source[i]);
                systemBase *= 16u;
            }

            if (result > int.MaxValue)
            {
                throw new ArgumentException($"{nameof(source)} does not represent a positive number in the hex numeral system.");
            }

            return (int)result;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source string presents a negative number
        /// - or
        /// contains invalid for given numeral system symbols
        /// -or-
        /// the radix is not equal 8, 10 or 16.
        /// </exception>
        public static int ParsePositiveByRadix(this string source, int radix)
        {
            if (radix is not 8 and not 10 and not 16)
            {
                throw new ArgumentException($"{nameof(radix)} is 8, 10 and 16 only.");
            }

            if (radix == 8)
            {
                return ParsePositiveFromOctal(source);
            }

            if (radix == 10)
            {
                return ParsePositiveFromDecimal(source);
            }

            if (radix == 16)
            {
                return ParsePositiveFromHex(source);
            }

            return 0;
        }

        /// <summary>
        /// Converts the string representation of a signed number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="source">The string representation of a signed number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A signed decimal value.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if source contains invalid for given numeral system symbols
        /// -or-
        /// the radix is not equal 8, 10 or 16.
        /// </exception>
        public static int ParseByRadix(this string source, int radix)
        {
            if (radix is not 8 and not 10 and not 16)
            {
                throw new ArgumentException($"{nameof(radix)} is 8, 10 and 16 only.");
            }

            uint result = 0u;
            uint systemBase = 1u;

            if (radix == 8)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                {
                    if (!char.IsDigit(source[i]) || source[i] > '7')
                    {
                        throw new ArgumentException($"{nameof(source)} does not represent a number in octal numeral system.");
                    }

                    result += systemBase * ParseCharToUint(source[i]);
                    systemBase *= 8u;
                }
            }

            if (radix == 10)
            {
                for (int i = source.Length - 1; i > 0; i--)
                {
                    if (!char.IsDigit(source[i]) || source[i] > '9')
                    {
                        throw new ArgumentException($"{nameof(source)} does not represent a number in decimal numeral system.");
                    }

                    result += systemBase * ParseCharToUint(source[i]);
                    systemBase *= 10u;
                }

                if (source[0] == '-')
                {
                    return (int)(result * -1);
                }
                else
                {
                    if (!char.IsDigit(source[0]) || source[0] > '9')
                    {
                        throw new ArgumentException($"{nameof(source)} does not represent a number in decimal numeral system.");
                    }

                    result += systemBase * ParseCharToUint(source[0]);
                }
            }

            if (radix == 16)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                {
                    if (!char.IsDigit(source[i]) && !(source[i] >= 'A' && source[i] <= 'F') && !(source[i] >= 'a' && source[i] <= 'f'))
                    {
                        throw new ArgumentException($"{nameof(source)} does not represent a number in hex numeral system.");
                    }

                    result += systemBase * ParseCharToUint(source[i]);
                    systemBase *= 16u;
                }
            }

            return (int)result;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the octal numeral system.</param>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromOctal(this string source, out int value)
        {
            try
            {
                value = ParsePositiveFromOctal(source);
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the decimal numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the decimal numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromDecimal(this string source, out int value)
        {
            try
            {
                value = ParsePositiveFromDecimal(source);
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the hex numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the hex numeral system.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParsePositiveFromHex(this string source, out int value)
        {
            try
            {
                value = ParsePositiveFromHex(source);
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Converts the string representation of a positive number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a positive number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown the radix is not equal 8, 10 or 16.</exception>
        public static bool TryParsePositiveByRadix(this string source, int radix, out int value)
        {
            if (radix is not 8 and not 10 and not 16)
            {
                throw new ArgumentException($"{nameof(radix)} is 8, 10 and 16 only.");
            }

            try
            {
                value = ParsePositiveByRadix(source, radix);
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Converts the string representation of a signed number in the octal, decimal or hex numeral system to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="source">The string representation of a signed number in the the octal, decimal or hex numeral system.</param>
        /// <param name="radix">The radix.</param>
        /// <returns>A positive decimal value.</returns>
        /// <param name="value">A positive decimal value.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown the radix is not equal 8, 10 or 16.</exception>
        public static bool TryParseByRadix(this string source, int radix, out int value)
        {
            if (radix is not 8 and not 10 and not 16)
            {
                throw new ArgumentException($"{nameof(radix)} is 8, 10 and 16 only.");
            }

            try
            {
                value = ParseByRadix(source, radix);
            }
            catch (ArgumentException)
            {
                value = 0;
                return false;
            }

            return true;
        }

        public static uint ParseCharToUint(char number)
        {
            switch (number)
            {
                case '0':
                    return 0u;
                case '1':
                    return 1u;
                case '2':
                    return 2u;
                case '3':
                    return 3u;
                case '4':
                    return 4u;
                case '5':
                    return 5u;
                case '6':
                    return 6u;
                case '7':
                    return 7;
                case '8':
                    return 8u;
                case '9':
                    return 9u;
                case 'A':
                case 'a':
                    return 10u;
                case 'B':
                case 'b':
                    return 11u;
                case 'C':
                case 'c':
                    return 12u;
                case 'D':
                case 'd':
                    return 13u;
                case 'E':
                case 'e':
                    return 14u;
                case 'F':
                case 'f':
                    return 15u;
                default:
                    throw new ArgumentException("Incorrect number.");
            }
        }
    }
}
