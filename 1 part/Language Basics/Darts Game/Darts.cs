using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            if (x > 10 || y > 10)
            {
                return 0;
            }

            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            switch (distance)
            {
                case (<= 1):
                    return 10;
                case (<= 5):
                    return 5;
                case (<= 10):
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
