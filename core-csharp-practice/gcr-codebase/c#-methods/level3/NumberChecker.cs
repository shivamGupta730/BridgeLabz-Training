using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumberChecker
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

        public static bool IsDuck(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] != 0)
                    return true;
            }
            return false;
        }

        public static bool IsArmstrong(int[] d)
        {
            int p = d.Length;
            int s = 0;

            for (int i = 0; i < d.Length; i++)
                s += (int)Math.Pow(d[i], p);

            int n = 0;
            for (int i = 0; i < d.Length; i++)
                n = n * 10 + d[i];

            return s == n;
        }

        public static int[] Largest(int[] d)
        {
            int f = Int32.MinValue;
            int s = Int32.MinValue;

            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > f)
                {
                    s = f;
                    f = d[i];
                }
                else if (d[i] > s && d[i] != f)
                {
                    s = d[i];
                }
            }
            return new int[] { f, s };
        }

        public static int[] Smallest(int[] d)
        {
            int f = Int32.MaxValue;
            int s = Int32.MaxValue;

            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] < f)
                {
                    s = f;
                    f = d[i];
                }
                else if (d[i] < s && d[i] != f)
                {
                    s = d[i];
                }
            }
            return new int[] { f, s };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());

            int cnt = NumberChecker.Count(n);
            int[] d = NumberChecker.Digits(n);

            Console.WriteLine("Digit count = " + cnt);

            Console.WriteLine("Digits:");
            for (int i = 0; i < d.Length; i++)
                Console.Write(d[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Duck Number = " + NumberChecker.IsDuck(d));
            Console.WriteLine("Armstrong Number = " + NumberChecker.IsArmstrong(d));

            int[] l = NumberChecker.Largest(d);
            Console.WriteLine("Largest = " + l[0] + " Second Largest = " + l[1]);

            int[] s = NumberChecker.Smallest(d);
            Console.WriteLine("Smallest = " + s[0] + " Second Smallest = " + s[1]);
        }
    }
}
