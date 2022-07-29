using System;
using System.Globalization;

namespace NumeralSystems
{
    public static class Converter
    {
        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the octal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the octal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveOctal(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number shouldn't be less than 0.");
            }

            if (number < 8)
            {
                return number.ToString(CultureInfo.InvariantCulture);
            }

            long result = 0;
            long factor = 1;

            while (number > 8)
            {
                result += (number % 8) * factor;
                number /= 8;
                factor *= 10;
            }

            result += number * factor;

            return result.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the decimal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the decimal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveDecimal(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number shouldn't be less than 0.");
            }

            return number.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in the hexadecimal numeral systems.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>The equivalent string representation of the number in the hexadecimal numeral systems.</returns>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveHex(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number shouldn't be less than 0.");
            }

            return number.ToString("X", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the value of a positive integer to its equivalent string representation in a specified radix.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="radix">Base of the numeral systems.</param>
        /// <returns>The equivalent string representation of the number in a specified radix.</returns>
        /// <exception cref="ArgumentException">Thrown if radix is not equal 8, 10 or 16.</exception>
        /// <exception cref="ArgumentException">Thrown if number is less than zero.</exception>
        public static string GetPositiveRadix(this int number, int radix)
        {
            if (radix is not 8 and not 10 and not 16)
            {
                throw new ArgumentException("Radix should be 8 or 10 or 16");
            }

            if (number < 0)
            {
                throw new ArgumentException("Number shouldn't be less than 0.");
            }

            if (number < radix)
            {
                return number.ToString(CultureInfo.InvariantCulture);
            }

            if (radix == 16)
            {
                return number.ToString("X", CultureInfo.InvariantCulture);
            }

            if (radix == 10)
            {
                return number.ToString(CultureInfo.InvariantCulture);
            }

            long result = 0;
            long factor = 1;

            while (number > radix)
            {
                result += (number % radix) * factor;
                number /= radix;
                factor *= 10;
            }

            result += number * factor;

            return result.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the value of a signed integer to its equivalent string representation in a specified radix.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="radix">Base of the numeral systems.</param>
        /// <returns>The equivalent string representation of the number in a specified radix.</returns>
        /// <exception cref="ArgumentException">Thrown if radix is not equal 8, 10 or 16.</exception>
        public static string GetRadix(this int number, int radix)
        {
            if (radix is not 8 and not 10 and not 16)
            {
                throw new ArgumentException("Radix should be 8 or 10 or 16");
            }

            if (number < 0)
            {
                uint unsignedNumber = (uint)number;

                if (unsignedNumber < radix)
                {
                    return unsignedNumber.ToString(CultureInfo.InvariantCulture);
                }

                if (radix == 16)
                {
                    return unsignedNumber.ToString("X", CultureInfo.InvariantCulture);
                }

                if (radix == 10)
                {
                    return unsignedNumber.ToString(CultureInfo.InvariantCulture);
                }

                long result = 0;
                long factor = 1;
                uint unRadix = (uint)radix;

                while (unsignedNumber > radix)
                {
                    result += (unsignedNumber % radix) * factor;
                    unsignedNumber /= unRadix;
                    factor *= 10;
                }

                result += unsignedNumber * factor;

                return result.ToString(CultureInfo.InvariantCulture);
            }

            return GetPositiveRadix(number, radix);
        }
    }
}
