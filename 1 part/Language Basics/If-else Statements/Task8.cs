namespace IfStatements
{
    public static class Task8
    {
        public static int DoSomething(int i1, int i2)
        {
            if (i1 >= -4 && i1 < 9)
            {
                if (i2 > 5)
                {
                    return i1 + i2;
                }

                if (i2 <= -3)
                {
                    return (i1 * 2) - i2;
                }
                else
                {
                    return i2 - (i1 * i1);
                }
            }
            else if (i1 < -4)
            {
                if (i2 >= 7)
                {
                    return (i2 * 2) - i1;
                }

                if (i2 < -5)
                {
                    return i2 - i1;
                }
                else
                {
                    return i1 - i2;
                }
            }
            else if (i1 >= 9)
            {
                if (i2 >= 7)
                {
                    return i1 - (i2 * i2);
                }
                else if (i2 < -7)
                {
                    return (i1 * 2) - (i2 * 2);
                }
            }

            return i2 * i1;
        }
    }
}
