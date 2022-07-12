namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (i == 0)
            {
                if (!b1 || b2)
                {
                    return 1;
                }

                return -1;
            }

            if (b1)
            {
               if (b2)
                {
                    if (i >= 4 && i < 8)
                    {
                        return i * 2;
                    }

                    if (i < -4 && i >= -8)
                    {
                        return i * 3;
                    }
                }
                else
                {
                    if (i > 3 && i <= 7)
                    {
                        return 10 - (i * 2);
                    }

                    if (i <= -3 && i > -7)
                    {
                        return 10 + (i * 3);
                    }
                }
            }
            else
            {
                if (b2)
                {
                    if (i < -8 || i >= 8)
                    {
                        return i - (i * i);
                    }

                    if (i > -4 && i <= 4)
                    {
                        return (i * i) - (i * i * i);
                    }
                }
                else
                {
                    if (i <= -7 || i > 7)
                    {
                        return i - (i * i * i);
                    }

                    if (i >= -3 && i < 3)
                    {
                        return (i * i * i) - (i * i);
                    }
                }
            }

            return i;
        }
    }
}
