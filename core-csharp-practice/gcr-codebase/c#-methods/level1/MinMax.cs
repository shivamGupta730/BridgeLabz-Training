using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class MinMax
    {
        public static int[] FindSmallestAndLargest(int n1, int n2, int n3)
        {
            int min = n1;
            int max = n1;

            if (n2 < min) min = n2;
            if (n3 < min) min = n3;

            if (n2 > max) max = n2;
            if (n3 > max) max = n3;

            return new int[] { min, max };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] res = MinMax.FindSmallestAndLargest(a, b, c);

            Console.WriteLine("Smallest = " + res[0]);
            Console.WriteLine("Largest = " + res[1]);
        }
    }
}
