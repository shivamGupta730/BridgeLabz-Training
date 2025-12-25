using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumberCheckerQuestion5
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static bool IsNeon(int n)
        {
            int sq = n * n;
            int s = 0;

            while (sq > 0)
            {
                s += sq % 10;
                sq /= 10;
            }
            return s == n;
        }

        public static bool IsSpy(int n)
        {
            int s = 0;
            int p = 1;

            while (n > 0)
            {
                int d = n % 10;
                s += d;
                p *= d;
                n /= 10;
            }
            return s == p;
        }

        public static bool IsAuto(int n)
        {
            int sq = n * n;
            return sq % (int)Math.Pow(10, Count(n)) == n;
        }

        public static bool IsBuzz(int n)
        {
            if (n % 7 == 0 || n % 10 == 7)
                return true;
            return false;
        }

        private static int Count(int n)
        {
            int c = 0;
            while (n > 0)
            {
                c++;
                n /= 10;
            }
            return c;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime = " + NumberCheckerQuestion5.IsPrime(n));
            Console.WriteLine("Neon = " + NumberCheckerQuestion5.IsNeon(n));
            Console.WriteLine("Spy = " + NumberCheckerQuestion5.IsSpy(n));
            Console.WriteLine("Automorphic = " + NumberCheckerQuestion5.IsAuto(n));
            Console.WriteLine("Buzz = " + NumberCheckerQuestion5.IsBuzz(n));
        }
    }
}
