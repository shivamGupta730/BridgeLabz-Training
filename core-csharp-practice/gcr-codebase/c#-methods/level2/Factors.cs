using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Factors
    {
        public static int[] Get(int n)
        {
            int cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    cnt++;
            }

            int[] arr = new int[cnt];
            int idx = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    arr[idx++] = i;
            }

            return arr;
        }

        public static int Sum(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
                s += a[i];
            return s;
        }

        public static int Prod(int[] a)
        {
            int p = 1;
            for (int i = 0; i < a.Length; i++)
                p *= a[i];
            return p;
        }

        public static double SqSum(int[] a)
        {
            double s = 0;
            for (int i = 0; i < a.Length; i++)
                s += Math.Pow(a[i], 2);
            return s;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            int[] f = Factors.Get(n);

            Console.WriteLine("Factors:");
            for (int i = 0; i < f.Length; i++)
                Console.Write(f[i] + " ");

            Console.WriteLine("\nSum = " + Factors.Sum(f));
            Console.WriteLine("Product = " + Factors.Prod(f));
            Console.WriteLine("Sum of Squares = " + Factors.SqSum(f));
        }
    }
}
