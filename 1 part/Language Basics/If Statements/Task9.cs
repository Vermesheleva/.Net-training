namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            if (i == 0 || (i >= -8 && i < -4) || (i > 4 && i < 8) || (i == 4 && !b) || (i == 8 && b))
            {
                return false;
            }

            return true;
        }
    }
}
