namespace IfStatements
{
    public static class Task3
    {
        public static bool DoSomething1(bool b)
        {
            return !b;
        }

        public static bool DoSomething2(bool b)
        {
            if (b)
            {
                return false;
            }

            return true;
        }
    }
}
