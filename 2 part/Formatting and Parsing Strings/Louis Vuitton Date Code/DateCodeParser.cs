using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeParser
    {
        /// <summary>
        /// Parses a date code and returns a <see cref="manufacturingYear"/> and <see cref="manufacturingMonth"/>.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseEarly1980Code(string dateCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 3 || dateCode.Length >= 5)
            {
                throw new ArgumentException("invalid dateCode");
            }

            int year = int.Parse(dateCode[..2], CultureInfo.InvariantCulture);
            if (year < 80 || year >= 90)
            {
                throw new ArgumentException("invalid dateCode");
            }

            int month = int.Parse(dateCode[2..], CultureInfo.InvariantCulture);
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("invalid dateCode");
            }

            manufacturingYear = (uint)(year + 1900);
            manufacturingMonth = (uint)month;
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseLate1980Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 5 || dateCode.Length > 6)
            {
                throw new ArgumentException("invalid dateCode");
            }

            int year = int.Parse(dateCode[..2], CultureInfo.InvariantCulture);
            if (year < 85 || year >= 90)
            {
                throw new ArgumentException("invalid dateCode");
            }

            int month;
            if (dateCode.Length == 5)
            {
                month = Convert.ToInt32(dateCode[2].ToString(), CultureInfo.InvariantCulture);
            }
            else
            {
                month = int.Parse(dateCode[2..4], CultureInfo.InvariantCulture);
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentException("invalid dateCode");
            }

            factoryLocationCountry = CountryParser.GetCountry(dateCode[^2..]);
            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("invalid country code");
            }

            factoryLocationCode = dateCode[^2..];
            manufacturingYear = (uint)(year + 1900);
            manufacturingMonth = (uint)month;
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void Parse1990Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length != 6)
            {
                throw new ArgumentException("invalid dateCode");
            }

            factoryLocationCountry = CountryParser.GetCountry(dateCode[0..2]);
            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("invalid country code");
            }

            factoryLocationCode = dateCode[0..2];

            int month = (Convert.ToInt32(dateCode[2].ToString(), CultureInfo.InvariantCulture) * 10)
                + Convert.ToInt32(dateCode[4].ToString(), CultureInfo.InvariantCulture);

            if (month < 1 || month > 12)
            {
                throw new ArgumentException("invalid dateCode");
            }

            int year = (Convert.ToInt32(dateCode[3].ToString(), CultureInfo.InvariantCulture) * 10)
                + Convert.ToInt32(dateCode[5].ToString(), CultureInfo.InvariantCulture);

            if (!(year < 6 || (year >= 90 && year < 100)))
            {
                throw new ArgumentException("invalid dateCode");
            }

            manufacturingYear = (uint)(year < 6 ? year + 2000 : year + 1900);
            manufacturingMonth = (uint)month;
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingWeek"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingWeek">A manufacturing week to return.</param>
        public static void Parse2007Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingWeek)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length != 6)
            {
                throw new ArgumentException("invalid dateCode");
            }

            factoryLocationCountry = CountryParser.GetCountry(dateCode[0..2]);
            if (factoryLocationCountry.Length == 0)
            {
                throw new ArgumentException("invalid country code");
            }

            factoryLocationCode = dateCode[0..2];

            int week = (Convert.ToInt32(dateCode[2].ToString(), CultureInfo.InvariantCulture) * 10)
                + Convert.ToInt32(dateCode[4].ToString(), CultureInfo.InvariantCulture);

            if (week < 1 || week > 53)
            {
                throw new ArgumentException("invalid dateCode");
            }

            int year = (Convert.ToInt32(dateCode[3].ToString(), CultureInfo.InvariantCulture) * 10)
                + Convert.ToInt32(dateCode[5].ToString(), CultureInfo.InvariantCulture);

            if (year < 7)
            {
                throw new ArgumentException("invalid dateCode");
            }

            manufacturingYear = (uint)year + 2000;

            int realNumOfWeeks = DateCodeGenerator.GetIso8601WeeksOfYear(manufacturingYear);
            if (week == 53 && realNumOfWeeks != 53)
            {
                throw new ArgumentException("invalid dateCode");
            }

            manufacturingWeek = (uint)week;
        }
    }
}
