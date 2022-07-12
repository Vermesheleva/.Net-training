namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (i == 0)
            {
                if (b1 || !b2)
                {
                    return -1;
                }

                return 1;
            }

            if (b1)
            {
                if (i >= 2 && i <= 9)
                {
                    if (b2)
                    {
                        return 10 - i;
                    }

                    return i + 10;
                }

                if (i <= -2 && i >= -9)
                {
                    if (b2)
                    {
                        return i + 5;
                    }

                    return 5 - i;
                }
            }

            if (!b1)
            {
                if (i <= -10 || i >= 10)
                {
                    if (b2)
                    {
                        return i + 1;
                    }

                    return i - 1;
                }

                if (i > -5 && i < 5)
                {
                    if (b2)
                    {
                        return i + 10;
                    }

                    return i - 10;
                }
            }

            return i;
        }
    }
}
