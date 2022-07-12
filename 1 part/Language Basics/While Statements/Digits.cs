namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;

            while (n > 10)
            {
                sum += n % 10;
                n /= 10;
            }

            if (n == 10)
            {
                return sum + 1;
            }

            return sum + n;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong product = 1;

            while (n > 10)
            {
                product *= n % 10;
                n /= 10;
            }

            if (n == 10)
            {
                return 0;
            }

            return product * n;
        }
    }
}
