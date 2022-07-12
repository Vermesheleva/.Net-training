using System;

namespace Gcd
{
    public static class IntegerExtensions
    {
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == 0)
            {
                return b < 0 ? Math.Abs(b) : b;
            }

            if (b == 0)
            {
                return a < 0 ? Math.Abs(a) : a;
            }

            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;

            if (a == b)
            {
                return a;
            }

            int prev = a > b ? a : b;
            int next = a < b ? a : b;
            int temp;

            while (prev % next != 0)
            {
                prev %= next;
                temp = prev;
                prev = next;
                next = temp;
            }

            return next;
        }

        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int gcd = GetGcdByEuclideanWithoutNullCheck(a, b);
            int result = GetGcdByEuclideanWithoutNullCheck(gcd, c);

            return result;
        }

        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            if (a == 0 && b == 0 && (other.All(elem => elem == 0) || other.Length == 0))
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int gcd = GetGcdByEuclideanWithoutNullCheck(a, b);
            int result = gcd;

            for (int i = 0; i < other.Length; i++)
            {
                result = GetGcdByEuclideanWithoutNullCheck(gcd, other[i]);
                gcd = result;
            }

            return result;
        }

        // I decided to add this method to not to write all this code incide the previous one.
        public static int GetGcdByEuclideanWithoutNullCheck(int a, int b)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0)
            {
                return b < 0 ? Math.Abs(b) : b;
            }

            if (b == 0)
            {
                return a < 0 ? Math.Abs(a) : a;
            }

            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;

            if (a == b)
            {
                return a;
            }

            int prev = a > b ? a : b;
            int next = a < b ? a : b;
            int temp;

            while (prev % next != 0)
            {
                prev %= next;
                temp = prev;
                prev = next;
                next = temp;
            }

            return next;
        }

        public static int GetGcdByStein(int a, int b)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;

            int i = 0;

            while (true)
            {
                if (a == 0)
                {
                    return i == 0 ? b : b * i;
                }

                if (b == 0)
                {
                    return i == 0 ? a : a * i;
                }

                if (a % 2 == 0 && b % 2 == 0)
                {
                    a /= 2;
                    b /= 2;
                    i += 2;
                }
                else if (a % 2 == 0)
                {
                    a /= 2;
                }
                else if (b % 2 == 0)
                {
                    b /= 2;
                }
                else
                {
                    int min = Math.Min(a, b);
                    a = Math.Abs(a - b);
                    b = min;
                }
            }
        }

        // And this one too.
        public static int GetGcdBySteinWithoutNullCheck(int a, int b)
        {
            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;

            int i = 0;

            while (true)
            {
                if (a == 0)
                {
                    return i == 0 ? b : b * i;
                }

                if (b == 0)
                {
                    return i == 0 ? a : a * i;
                }

                if (a % 2 == 0 && b % 2 == 0)
                {
                    a /= 2;
                    b /= 2;
                    i += 2;
                }
                else if (a % 2 == 0)
                {
                    a /= 2;
                }
                else if (b % 2 == 0)
                {
                    b /= 2;
                }
                else
                {
                    int min = Math.Min(a, b);
                    a = Math.Abs(a - b);
                    b = min;
                }
            }
        }

        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int gcd = GetGcdBySteinWithoutNullCheck(a, b);
            int result = GetGcdBySteinWithoutNullCheck(gcd, c);

            return result;
        }

        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            if (a == 0 && b == 0 && (other.All(elem => elem == 0) || other.Length == 0))
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int gcd = GetGcdBySteinWithoutNullCheck(a, b);
            int result = gcd;

            for (int i = 0; i < other.Length; i++)
            {
                result = GetGcdBySteinWithoutNullCheck(gcd, other[i]);
                gcd = result;
            }

            return result;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            DateTime start = DateTime.Now;

            int result = GetGcdByEuclidean(a, b);

            DateTime end = DateTime.Now;
            elapsedTicks = start.Ticks - end.Ticks;

            return result;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            DateTime start = DateTime.Now;

            int result = GetGcdByEuclidean(a, b, c);

            DateTime end = DateTime.Now;
            elapsedTicks = start.Ticks - end.Ticks;

            return result;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            DateTime start = DateTime.Now;

            int result = GetGcdByEuclidean(a, b, other);

            DateTime end = DateTime.Now;
            elapsedTicks = start.Ticks - end.Ticks;

            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            DateTime start = DateTime.Now;

            int result = GetGcdByStein(a, b);

            DateTime end = DateTime.Now;
            elapsedTicks = start.Ticks - end.Ticks;

            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            DateTime start = DateTime.Now;

            int result = GetGcdByStein(a, b, c);

            DateTime end = DateTime.Now;
            elapsedTicks = start.Ticks - end.Ticks;

            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            DateTime start = DateTime.Now;

            int result = GetGcdByStein(a, b, other);

            DateTime end = DateTime.Now;
            elapsedTicks = start.Ticks - end.Ticks;

            return result;
        }
    }
}
