using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NatSum
    {
        public static int Rec(int n)
        {
            if (n == 0)
                return 0;
            return n + Rec(n - 1);
        }

        public static int Form(int n)
        {
            return n * (n + 1) / 2;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Not a natural number");
                return;
            }

            int r1 = NatSum.Rec(n);
            int r2 = NatSum.Form(n);

            Console.WriteLine("Sum using Recursion = " + r1);
            Console.WriteLine("Sum using Formula = " + r2);

            if (r1 == r2)
                Console.WriteLine("Both results are correct and equal");
            else
                Console.WriteLine("Results are not equal");
        }
    }
}
