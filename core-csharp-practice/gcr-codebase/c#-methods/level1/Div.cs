using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Div
    {
        public static int[] Cal(int a, int b)
        {
            int q = a / b;
            int r = a % b;
            return new int[] { q, r };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int[] res = Div.Cal(a, b);

            Console.WriteLine("Quotient = " + res[0]);
            Console.WriteLine("Remainder = " + res[1]);
        }
    }
}
