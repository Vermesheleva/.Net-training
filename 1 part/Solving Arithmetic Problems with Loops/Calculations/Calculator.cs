using System;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }

        public static double GetSumTwo(int n)
        {
            double sum = 0;
            double sign = -1;

            for (double i = 1; i <= n; i++)
            {
                sign *= -1;
                sum += sign / (i * (i + 1));
            }

            return sum;
        }

        public static double GetSumThree(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow(i, 5);
            }

            return sum;
        }

        public static double GetSumFour(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow((2 * i) + 1, 2);
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double product = 1;

            for (int i = 1; i <= n; i++)
            {
                product *= 1.0 + (1 / Math.Pow(i, 2));
            }

            return product;
        }

        public static double GetSumFive(int n)
        {
            double sum = 0;
            double sign = 1;

            for (int i = 1; i <= n; i++)
            {
                sign *= -1;
                sum += sign / ((2 * i) + 1);
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double num = 1;
            double denum = 1;
            double sum = 1;

            for (int i = 2; i <= n; i++)
            {
                num *= i;
                denum += 1.0 / i;
                sum += num / denum;
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double result = Math.Sqrt(2);

            for (int i = 1; i < n; i++)
            {
                result = Math.Sqrt(2 + result);
            }

            return result;
        }

        public static double GetSumEight(int n)
        {
            double denum = 0;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                denum += Math.Sin((Math.PI * i) / 180);
                sum += 1 / denum;
            }

            return sum;
        }
    }
}
