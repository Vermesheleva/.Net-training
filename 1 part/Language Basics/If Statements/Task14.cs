namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1)
            {
                if (b2)
                {
                    if (i > -5 && i <= 5)
                    {
                        return -i * 2;
                    }

                    return 10 - (i * 2);
                }
                else
                {
                    if (i > -5 && i <= 5)
                    {
                        return i * i;
                    }

                    return i * i * i;
                }
            }
            else
            {
                if (i < -9 || i > 7)
                {
                    return -i;
                }

                if (b2)
                {
                    if (i < -7 || (i >= -3 && i <= 7))
                    {
                        return i;
                    }

                    return i * 10;
                }
                else
                {
                    if (i < -3 || (i >= 5 && i <= 7) || i == 0)
                    {
                        return i;
                    }

                    return -i * 100;
                }
            }
        }
    }
}
