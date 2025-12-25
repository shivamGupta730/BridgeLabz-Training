using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumCheck
    {
        public static bool IsPos(int n)
        {
            if (n >= 0)
                return true;
            return false;
        }

        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        public static int Comp(int a, int b)
        {
            if (a > b)
                return 1;
            if (a == b)
                return 0;
            return -1;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter number:");
                a[i] = int.Parse(Console.ReadLine());

                if (NumCheck.IsPos(a[i]))
                {
                    if (NumCheck.IsEven(a[i]))
                        Console.WriteLine("Positive Even");
                    else
                        Console.WriteLine("Positive Odd");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }

            int r = NumCheck.Comp(a[0], a[a.Length - 1]);

            if (r == 1)
                Console.WriteLine("First is Greater");
            else if (r == 0)
                Console.WriteLine("Both are Equal");
            else
                Console.WriteLine("First is Less");
        }
    }
}
