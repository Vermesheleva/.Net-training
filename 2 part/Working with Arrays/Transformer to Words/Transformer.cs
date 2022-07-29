using System;
using System.Globalization;

namespace TransformerToWords
{
    /// <summary>
    /// Implements transformer class.
    /// </summary>
    public class Transformer
    {
        private double[] doubles;

        public Transformer()
        {
            this.doubles = Array.Empty<double>();
        }

        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="ind"> Index of number to convert.</param>
        /// <returns>Words representation.</returns
        public string TransformToWords(int ind)
        {
            double number = this.doubles[ind];

            if (number is double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (number is double.NaN)
            {
                return "Not a Number";
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
                    default:
                        break;
                }
            }

            return char.ToUpper(result[1], CultureInfo.InvariantCulture) + result[2..];
        }

        /// <summary>
        /// Transforms each element of source array into its 'word format'.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of 'word format' of elements of source array.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <example>
        /// new[] { 2.345, -0.0d, 0.0d, 0.1d } => { "Two point three four five", "Minus zero", "Zero", "Zero point one" }.
        /// </example>
        public string[] Transform(double[]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array is empty.");
            }

            this.doubles = source;
            string[] result = new string[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                result[i] = this.TransformToWords(i);
            }

            return result;
        }
    }
}
