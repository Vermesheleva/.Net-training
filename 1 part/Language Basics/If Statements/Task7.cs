﻿namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b && (i > -7 && i < 7))
            {
                return 7 - i;
            }

            if (!b && (i <= -5 || i >= 5))
            {
                return i + 5;
            }

            return i;
        }
    }
}
