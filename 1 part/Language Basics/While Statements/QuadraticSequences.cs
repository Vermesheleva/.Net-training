﻿namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            int i = 1;
            long term = 0;
            long sum = 0;

            while (term <= maxTerm)
            {
                term = (a * i * i) + (b * i) + c;

                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long i = startN;
            long sum = 0;

            while (count > 0)
            {
                sum += (a * i * i) + (b * i) + c;
                count--;
                i++;
            }

            return sum;
        }
    }
}
