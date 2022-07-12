namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
           if (b && ((i < -3 && i >= -6) || (i > 3 && i <= 6) || i == 0))
           {
                return false;
           }

           if (!b)
           {
                if (i == 0)
                {
                    return false;
                }

                if ((i <= -3 && i >= -6) || (i >= 3 && i <= 6))
                {
                    return false;
                }
           }

           return true;
        }
    }
}
