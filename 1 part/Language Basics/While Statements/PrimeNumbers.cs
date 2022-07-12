namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n == 2)
            {
                return true;
            }

            if (n == 1)
            {
                return false;
            }

            if (n % 2 == 0)
            {
                return false;
            }

            uint div = 3;
            double max = Math.Sqrt(n);

            while (div <= max)
            {
                if (n % div == 0)
                {
                    return false;
                }

                div += 2;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            if (n < 2)
            {
                return 0;
            }

            while (n > 2)
            {
                if (IsPrimeNumber(n))
                {
                    return n;
                }

                n--;
            }

            return 2;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            if (count == 0 || n < 2)
            {
                return 0;
            }

            if (n == 2)
            {
                return 2;
            }

            uint elem = GetLastPrimeNumber(n);
            uint sum = elem;
            count--;

            while (count > 0)
            {
                elem = GetLastPrimeNumber(elem - 1);
                sum += elem;
                count--;
            }

            return sum;
        }
    }
}
