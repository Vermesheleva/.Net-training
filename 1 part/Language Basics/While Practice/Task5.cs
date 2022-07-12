namespace WhilePractice
{
    public static class Task5
    {
        public static double GetSequenceProduct(int n)
        {
            double product = 1;
            int i = 1;

            while (i <= n)
            {
                product *= 1 + (1 / Math.Pow(i, 2));
                i++;
            }

            return product;
        }
    }
}
