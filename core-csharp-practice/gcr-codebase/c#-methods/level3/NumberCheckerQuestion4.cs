using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumberCheckerQuestion4
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

        public static int[] Reverse(int[] d)
        {
            int[] r = new int[d.Length];
            int j = 0;

            for (int i = d.Length - 1; i >= 0; i--)
            {
                r[j++] = d[i];
            }
            return r;
        }

        public static bool Compare(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        public static bool IsPalindrome(int[] d)
        {
            int[] r = Reverse(d);
            return Compare(d, r);
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
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());

            int[] d = NumberCheckerQuestion4.Digits(n);

            Console.WriteLine("Digits:");
            for (int i = 0; i < d.Length; i++)
                Console.Write(d[i] + " ");
            Console.WriteLine();

            int[] r = NumberCheckerQuestion4.Reverse(d);

            Console.WriteLine("Reversed:");
            for (int i = 0; i < r.Length; i++)
                Console.Write(r[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Palindrome = " + NumberCheckerQuestion4.IsPalindrome(d));
            Console.WriteLine("Duck Number = " + NumberCheckerQuestion4.IsDuck(d));
        }
    }
}
