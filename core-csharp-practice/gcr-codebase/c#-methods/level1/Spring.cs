using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Spring
    {
        public bool IsSpring(int m, int d)
        {
            if ((m == 3 && d >= 20) ||
                (m == 4) ||
                (m == 5) ||
                (m == 6 && d <= 20))
            {
                return true;
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(args[0]);
            int d = int.Parse(args[1]);

            Spring s = new Spring();
            bool res = s.IsSpring(m, d);

            if (res)
                Console.WriteLine("Its a Spring Season");
            else
                Console.WriteLine("Not a Spring Season");
        }
    }
}
