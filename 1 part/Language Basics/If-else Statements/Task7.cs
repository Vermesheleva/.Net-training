namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
           if (b && (i < -5 || i >= 5))
            {
                return i + 10;
            }
           else if (b && (i >= -5 && i < 5))
            {
                return 10 - (i * i);
            }
           else if (!b && (i <= -7 || i > 4))
            {
                return i - 100;
            }
           else if (!b && (i > -7 && i <= 4))
            {
                return 10 - i;
            }
            else
            {
                return 0;
            }
        }
    }
}
