using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Sum
    {
        public int Cal(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            return s;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());

            Sum obj = new Sum();
            int res = obj.Cal(n);

            Console.WriteLine("Sum = " + res);
        }
    }
}
