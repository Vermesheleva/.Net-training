﻿namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i < 0 && i >= -3)
            {
                return i + (2 * i);
            }

            if (i > 0 && i <= 3)
            {
                return i - (i * i);
            }

            return i;
        }
    }
}
