namespace WhilePractice
{
    public static class Task6
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;
            int sign = 1;

            while (i <= n)
            {
                sign *= -1;
                sum += sign / ((2 * i) + 1);
                i++;
            }

            return sum;
        }
    }
}
