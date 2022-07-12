using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        public static int FindGcd(int a, int b)
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

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

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
    }
}
