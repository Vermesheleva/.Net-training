﻿namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            if (i < 0 && i >= -5)
            {
                return i + 5;
            }

            if (i > 0 && i <= 5)
            {
                return i - 5;
            }

            return i;
        }
    }
}
