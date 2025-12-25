using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumberCheckerQuestion3
    {
        public static int Count(int n)
        {
            int c = 0;
            while (n > 0)
            {
                c++;
                n /= 10;
            }
            return c;
        }

        public static int[] Digits(int n)
        {
            int cnt = Count(n);
            int[] d = new int[cnt];

            for (int i = cnt - 1; i >= 0; i--)
            {
                d[i] = n % 10;
                n /= 10;
            }
            return d;
        }

        public static int Sum(int[] d)
        {
            int s = 0;
            for (int i = 0; i < d.Length; i++)
                s += d[i];
            return s;
        }

        public static int SqSum(int[] d)
        {
            int s = 0;
            for (int i = 0; i < d.Length; i++)
                s += (int)Math.Pow(d[i], 2);
            return s;
        }

        public static bool IsHarshad(int n, int[] d)
        {
            int s = Sum(d);
            if (s == 0)
                return false;
            return n % s == 0;
        }

        public static int[,] Freq(int[] d)
        {
            int[,] f = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                f[i, 0] = i;
                f[i, 1] = 0;
            }

            for (int i = 0; i < d.Length; i++)
            {
                f[d[i], 1]++;
            }
            return f;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());

            int[] d = NumberCheckerQuestion3.Digits(n);

            Console.WriteLine("Digit count = " + NumberCheckerQuestion3.Count(n));
            Console.WriteLine("Sum of digits = " + NumberCheckerQuestion3.Sum(d));
            Console.WriteLine("Sum of squares = " + NumberCheckerQuestion3.SqSum(d));
            Console.WriteLine("Harshad Number = " + NumberCheckerQuestion3.IsHarshad(n, d));

            int[,] f = NumberCheckerQuestion3.Freq(d);

            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < 10; i++)
            {
                if (f[i, 1] > 0)
                    Console.WriteLine(f[i, 0] + " -> " + f[i, 1]);
            }
        }
    }
}
