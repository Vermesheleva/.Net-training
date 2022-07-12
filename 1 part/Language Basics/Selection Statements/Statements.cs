using System;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
           if (first > second)
            {
                if (first > third)
                {
                    Console.Write("Number {0} is the largest", first);
                }
                else
                {
                    Console.Write("Number {0} is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.Write("Number {0} is the largest", second);
                }
                else
                {
                    Console.Write("Number {0} is the largest", third);
                }
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second)
            {
                Console.WriteLine("Number {0} is the largest", first > third ? first : third);
            }
            else
            {
                Console.WriteLine("Number {0} is the largest", second > third ? second : third);
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (third > first && second < third)
            {
                Console.Write("Number {0} is the largest", third);
            }
            else if (second > third && second > first)
            {
                Console.Write("Number {0} is the largest", second);
            }
            else
            {
                Console.Write("Number {0} is the largest", first);
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10_000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100_000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if ((int)dayOfWeek == 1)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if ((int)dayOfWeek == 5)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else if ((int)dayOfWeek == 0 || (int)dayOfWeek == 6)
            {
                Console.WriteLine("The weekend.");
            }
            else
            {
                Console.WriteLine("The middle of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch ((int)dayOfWeek)
            {
                case 1:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case 5:
                    Console.WriteLine("The last day of the work week.");
                    break;
                case 0:
                case 6:
                    Console.WriteLine("The weekend.");
                    break;

                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return arg + " is sbyte.";
            }
            else if (arg is byte)
            {
                return arg + " is byte.";
            }
            else if (arg is short)
            {
                return arg + " is short.";
            }
            else if (arg is int)
            {
                return arg + " is int.";
            }
            else if (arg is long)
            {
                return arg + " is long.";
            }
            else if (arg is ushort)
            {
                return arg + " is ushort.";
            }
            else if (arg is uint)
            {
                return arg + " is uint.";
            }
            else if (arg is ulong)
            {
                return arg + " is ulong.";
            }
            else
            {
                return arg + " is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte:
                    return arg + " is sbyte.";
                case byte:
                    return arg + " is byte.";
                case short:
                    return arg + " is short.";
                case int:
                    return arg + " is int.";
                case long:
                    return arg + " is long.";
                case ushort:
                    return arg + " is ushort.";
                case uint:
                    return arg + " is uint.";
                case ulong:
                    return arg + " is ulong.";
                default:
                    return arg + " is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            return arg switch
            {
                sbyte => arg + " is sbyte.",
                byte => arg + " is byte.",
                short => arg + " is short.",
                int => arg + " is int.",
                long => arg + " is long.",
                ushort => arg + " is ushort.",
                uint => arg + " is uint.",
                ulong => arg + " is ulong.",
                _ => arg + " is not integer.",
            };
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch ((int)month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("It's winter now.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It's spring now.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It's summer now.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number == int.MinValue)
            {
                return 10;
            }

            int checkLength = Math.Abs(number);

            if (checkLength < 10)
            {
                return 1;
            }
            else if (checkLength < 100)
            {
                return 2;
            }
            else if (checkLength < 1000)
            {
                return 3;
            }
            else if (checkLength < 10_000)
            {
                return 4;
            }
            else if (checkLength < 100_000)
            {
                return 5;
            }
            else if (checkLength < 1_000_000)
            {
                return 6;
            }
            else if (checkLength < 10_000_000)
            {
                return 7;
            }
            else if (checkLength < 100_000_000)
            {
                return 8;
            }
            else if (checkLength < 1_000_000_000)
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }

        public static byte GetLengthWithSwitchExpression(int number)
        {
            if (number == int.MinValue)
            {
                return 10;
            }

            int checkLength = Math.Abs(number);

            switch (checkLength)
            {
                case (< 10):
                    return 1;
                case (< 100):
                    return 2;
                case (< 1000):
                    return 3;
                case (< 10_000):
                    return 4;
                case (< 100_000):
                    return 5;
                case (< 1_000_000):
                    return 6;
                case (< 10_000_000):
                    return 7;
                case (< 100_000_000):
                    return 8;
                case (< 1_000_000_000):
                    return 9;
                default:
                    return 10;
            }
        }

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month < 1)
            {
                return null;
            }
            else if (month > 12)
            {
                return null;
            }
            else
            {
                return (Month)month;
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case (< 1):
                case (> 12):
                    return null;
                default:
                    return (Month)month;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month)
        {
            return month switch
            {
                (< 1) => null,
                (> 12) => null,
                _ => (Month)month,
            };
        }
    }
}
