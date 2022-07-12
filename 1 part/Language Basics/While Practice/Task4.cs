namespace WhilePractice
{
    public static class Task4
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;

            while (i <= n)
            {
                sum += 1 / (((2 * i) + 1) * ((2 * i) + 1));
                i++;
            }

            return sum;
        }
    }
}
