using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (number == int.MaxValue && add > 0 && count > 1)
            {
                throw new OverflowException();
            }

            if (number == int.MinValue && add < 0 && count > 1)
            {
                throw new OverflowException();
            }

            if (count < 0)
            {
                throw new ArgumentException("Count should be >= 0.", nameof(count));
            }

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += number + (i * add);
            }

            return sum;
        }
    }
}
