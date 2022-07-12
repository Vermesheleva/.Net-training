using System;
using System.Globalization;

namespace TransformToWords
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public static class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public static string TransformToWords(double number)
        {
            if (number is double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (number is double.NaN)
            {
                return "NaN";
            }

            if (number is double.PositiveInfinity)
            {
                return "Positive Infinity";
            }

            if (number is double.NegativeInfinity)
            {
                return "Negative Infinity";
            }

            string numberToTransform = number.ToString(CultureInfo.InvariantCulture);
            string result = string.Empty;

            for (int i = 0; i < numberToTransform.Length; i++)
            {
                switch (numberToTransform[i])
                {
                    case '0':
                        result = string.Concat(result, " zero");
                        break;
                    case '1':
                        result = string.Concat(result, " one");
                        break;
                    case '2':
                        result = string.Concat(result, " two");
                        break;
                    case '3':
                        result = string.Concat(result, " three");
                        break;
                    case '4':
                        result = string.Concat(result, " four");
                        break;
                    case '5':
                        result = string.Concat(result, " five");
                        break;
                    case '6':
                        result = string.Concat(result, " six");
                        break;
                    case '7':
                        result = string.Concat(result, " seven");
                        break;
                    case '8':
                        result = string.Concat(result, " eight");
                        break;
                    case '9':
                        result = string.Concat(result, " nine");
                        break;
                    case '.':
                        result = string.Concat(result, " point");
                        break;
                    case 'E':
                        result = string.Concat(result, " E");
                        if (numberToTransform[i + 1] != '-')
                        {
                            result = string.Concat(result, " plus");
                        }

                        break;
                    case '-':
                        result = string.Concat(result, " minus");
                        break;
                    case 'd':
                        break;
                    default:
                        break;
                }
            }

            return char.ToUpper(result[1], CultureInfo.InvariantCulture) + result[2..];
        }
    }
}
