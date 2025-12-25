using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumberCheckerQuestion6
    {
        public static int[] Factors(int n)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0) c++;

            int[] f = new int[c];
            int k = 0;

            for (int i = 1; i <= n; i++)
                if (n % i == 0) f[k++] = i;

            return f;
        }

        public static int Greatest(int[] f)
        {
            int m = f[0];
            for (int i = 1; i < f.Length; i++)
                if (f[i] > m) m = f[i];
            return m;
        }

        public static int Sum(int[] f)
        {
            int s = 0;
            for (int i = 0; i < f.Length; i++)
                s += f[i];
            return s;
        }

        public static int Prod(int[] f)
        {
            int p = 1;
            for (int i = 0; i < f.Length; i++)
                p *= f[i];
            return p;
        }

        public static double CubeProd(int[] f)
        {
            double p = 1;
            for (int i = 0; i < f.Length; i++)
                p *= Math.Pow(f[i], 3);
            return p;
        }

        public static bool IsPerfect(int n, int[] f)
        {
            int s = 0;
            for (int i = 0; i < f.Length - 1; i++)
                s += f[i];
            return s == n;
        }

        public static bool IsAbundant(int n, int[] f)
        {
            int s = 0;
            for (int i = 0; i < f.Length - 1; i++)
                s += f[i];
            return s > n;
        }

        public static bool IsDeficient(int n, int[] f)
        {
            int s = 0;
            for (int i = 0; i < f.Length - 1; i++)
                s += f[i];
            return s < n;
        }

        public static bool IsStrong(int n)
        {
            int t = n;
            int s = 0;

            while (t > 0)
            {
                int d = t % 10;
                s += Fact(d);
                t /= 10;
            }
            return s == n;
        }

        private static int Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());

            int[] f = NumberCheckerQuestion6.Factors(n);

            Console.WriteLine("Factors:");
            for (int i = 0; i < f.Length; i++)
                Console.Write(f[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Greatest Factor = " + NumberCheckerQuestion6.Greatest(f));
            Console.WriteLine("Sum = " + NumberCheckerQuestion6.Sum(f));
            Console.WriteLine("Product = " + NumberCheckerQuestion6.Prod(f));
            Console.WriteLine("Cube Product = " + NumberCheckerQuestion6.CubeProd(f));

            Console.WriteLine("Perfect = " + NumberCheckerQuestion6.IsPerfect(n, f));
            Console.WriteLine("Abundant = " + NumberCheckerQuestion6.IsAbundant(n, f));
            Console.WriteLine("Deficient = " + NumberCheckerQuestion6.IsDeficient(n, f));
            Console.WriteLine("Strong = " + NumberCheckerQuestion6.IsStrong(n));
        }
    }
}
