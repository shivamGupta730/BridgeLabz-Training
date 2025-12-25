using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Random
    {
        public static int[] Gen(int n)
        {
            int[] a = new int[n];
            System.Random r = new System.Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(1000, 10000);
            }
            return a;
        }

        public static double[] Calc(int[] a)
        {
            int min = a[0];
            int max = a[0];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                min = Math.Min(min, a[i]);
                max = Math.Max(max, a[i]);
            }

            double avg = (double)sum / a.Length;
            return new double[] { avg, min, max };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            int[] a = Random.Gen(5);

            Console.WriteLine("Numbers:");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            double[] r = Random.Calc(a);

            Console.WriteLine("Average = " + r[0]);
            Console.WriteLine("Min = " + r[1]);
            Console.WriteLine("Max = " + r[2]);
        }
    }
}
