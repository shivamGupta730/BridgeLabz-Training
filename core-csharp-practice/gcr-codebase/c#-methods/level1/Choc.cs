 using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Choc
    {
        public static int[] Div(int c, int n)
        {
            int each = c / n;
            int rem = c % n;
            return new int[] { each, rem };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of chocolates:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of children:");
            int n = int.Parse(Console.ReadLine());

            int[] res = Choc.Div(c, n);

            Console.WriteLine("Each child gets = " + res[0]);
            Console.WriteLine("Remaining chocolates = " + res[1]);
        }
    }
}
