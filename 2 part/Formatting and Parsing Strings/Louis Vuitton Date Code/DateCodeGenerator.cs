using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1980 || manufacturingYear >= 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            string year = manufacturingYear.ToString(CultureInfo.InvariantCulture);
            string month = manufacturingMonth.ToString(CultureInfo.InvariantCulture);

            return year[2..] + month;
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            if (manufacturingDate.Year < 1980 || manufacturingDate.Year >= 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            string month = manufacturingDate.Month.ToString(CultureInfo.InvariantCulture);
            string year = manufacturingDate.Year.ToString(CultureInfo.InvariantCulture);

            return year[2..] + month;
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1985 || manufacturingYear >= 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2)
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string year = manufacturingYear.ToString(CultureInfo.InvariantCulture);
            string month = manufacturingMonth.ToString(CultureInfo.InvariantCulture);

            if (!factoryLocationCode.All(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid factory code.");
            }

            return year[2..] + month + factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (manufacturingDate.Year < 1985 || manufacturingDate.Year >= 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (manufacturingDate.Month < 1 || manufacturingDate.Month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2)
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string year = manufacturingDate.Year.ToString(CultureInfo.InvariantCulture);
            string month = manufacturingDate.Month.ToString(CultureInfo.InvariantCulture);

            if (!factoryLocationCode.All(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid factory code.");
            }

            return year[2..] + month + factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1990 || manufacturingYear > 2006)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth < 1 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2)
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string year = manufacturingYear.ToString(CultureInfo.InvariantCulture);
            string month = manufacturingMonth.ToString(CultureInfo.InvariantCulture);

            if (!factoryLocationCode.All(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string result = factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
            result += month.Length == 1 ? '0' : month[0];
            result += year[2];
            result += month.Length == 1 ? month[0] : month[1];

            return result + year[3];
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (manufacturingDate.Year < 1990 || manufacturingDate.Year > 2006)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (manufacturingDate.Month < 1 || manufacturingDate.Month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2)
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string year = manufacturingDate.Year.ToString(CultureInfo.InvariantCulture);
            string month = manufacturingDate.Month.ToString(CultureInfo.InvariantCulture);

            if (!factoryLocationCode.All(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string result = factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
            result += month.Length == 1 ? '0' : month[0];
            result += year[2];
            result += month.Length == 1 ? month[0] : month[1];

            return result + year[3];
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingWeek">A manufacturing week number.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            if (manufacturingYear < 2007)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingWeek < 1 || manufacturingWeek > 53)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek));
            }

            int realNumOfWeeks = GetIso8601WeeksOfYear(manufacturingYear);
            if (manufacturingWeek == 53 && realNumOfWeeks != 53)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2)
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string year = manufacturingYear.ToString(CultureInfo.InvariantCulture);
            string week = manufacturingWeek.ToString(CultureInfo.InvariantCulture);

            if (!factoryLocationCode.All(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string result = factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
            result += week.Length == 1 ? '0' : week[0];
            result += year[2];
            result += week.Length == 1 ? week[0] : week[1];

            return result + year[3];
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (manufacturingDate.Year < 2007)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            int weeks = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(manufacturingDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (factoryLocationCode.Length != 2)
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string year = manufacturingDate.Year.ToString(CultureInfo.InvariantCulture);

            if (manufacturingDate.Month == 1 && GetIso8601RealYear(manufacturingDate.Year, weeks))
            {
                year = (int.Parse(year, CultureInfo.InvariantCulture) - 1).ToString(CultureInfo.InvariantCulture);
            }

            string week = weeks.ToString(CultureInfo.InvariantCulture);

            if (!factoryLocationCode.All(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid factory code.");
            }

            string result = factoryLocationCode.ToUpper(CultureInfo.InvariantCulture);
            result += week.Length == 1 ? '0' : week[0];
            result += year[2];
            result += week.Length == 1 ? week[0] : week[1];

            return result + year[3];
        }

        public static int GetIso8601WeeksOfYear(uint year)
        {
            DateTime date = new DateTime((int)year, 12, 31);

            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(date);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                date = date.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static bool GetIso8601RealYear(int year, int week)
        {
            DateTime date = new DateTime(year, 1, 4);
            int firstWeek = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int weeksInYear = GetIso8601WeeksOfYear((uint)year);

            if (weeksInYear != 53 && week != firstWeek)
            {
                return true;
            }

            return false;
        }
    }
}
