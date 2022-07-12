namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            uint i = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;

                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint firstTerm = 13;
            const uint commonRatio = 3;

            uint sum = 0;
            uint i = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;

                while (j < i)
                {
                    rpow *= commonRatio;
                    j++;
                }

                sum += firstTerm * rpow;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            if (maxTerm < a)
            {
                return 0;
            }

            if (maxTerm == a)
            {
                return 1;
            }

            uint term = a;
            uint i = 0;

            while (term <= maxTerm)
            {
                term *= r;
                i++;
            }

            return i;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint term = a;
            uint i = 0;

            while (term < minTerm)
            {
                term *= r;
                i++;
            }

            return n - i;
        }
    }
}
