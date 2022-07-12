using System;

namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, world!");
        }

        public static void SayHelloUser(string userName)
        {
            string messege = "Hello, " + userName + "!";

            Console.WriteLine(messege);
        }

        public static void PrintFace()
        {
            Console.Write($" +\"\"\"\"\"+{Environment.NewLine}" +
                              $"(| o o |){Environment.NewLine}" +
                              $" |  ^  |{Environment.NewLine}" +
                              $" | '-' |{Environment.NewLine}" +
                              $" +-----+{Environment.NewLine}");
        }
    }
}
