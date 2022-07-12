﻿namespace WhileStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            int i = 0;
            int sum = 0;

            while (i < n)
            {
                sum += a + i;
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            const int firstTerm = 17;
            const int commonDifference = 33;

            int sum = 0;
            int i = 0;

            while (i < n)
            {
                sum += firstTerm + (commonDifference * i);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            const int commonDifference = 3;

            int sum = 0;
            int i = 0;

            while (i < n)
            {
                sum += a + (commonDifference * i);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms4(int a, int d, int n)
        {
            int sum = 0;
            int i = 0;

            while (i < n)
            {
                sum += a + (d * i);
                i++;
            }

            return sum;
        }
    }
}
