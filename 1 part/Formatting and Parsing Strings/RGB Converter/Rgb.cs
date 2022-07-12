using System;
using System.Globalization;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            red = red < 0 ? 0 : red;
            red = red > 255 ? 255 : red;

            green = green < 0 ? 0 : green;
            green = green > 255 ? 255 : green;

            blue = blue < 0 ? 0 : blue;
            blue = blue > 255 ? 255 : blue;

            string redHexValue = Convert.ToString(red, 16);
            string greenHexValue = Convert.ToString(green, 16);
            string blueHexValue = Convert.ToString(blue, 16);

            string result = redHexValue.Length == 1 ? '0' + redHexValue : redHexValue;
            result += greenHexValue.Length == 1 ? '0' + greenHexValue : greenHexValue;
            result += blueHexValue.Length == 1 ? '0' + blueHexValue : blueHexValue;

            return result.ToUpper(CultureInfo.InvariantCulture);
        }
    }
}
