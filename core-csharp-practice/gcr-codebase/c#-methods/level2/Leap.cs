using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Leap
    {
        public static bool IsLeap(int y)
        {
            if (y < 1582)
                return false;

            if (y % 400 == 0)
                return true;

            if (y % 4 == 0 && y % 100 != 0)
                return true;

            return false;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int y = int.Parse(Console.ReadLine());

            if (Leap.IsLeap(y))
                Console.WriteLine("Year is a Leap Year");
            else
                Console.WriteLine("Year is not a Leap Year");
        }
    }
}
