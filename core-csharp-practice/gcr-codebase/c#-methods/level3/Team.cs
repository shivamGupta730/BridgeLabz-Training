using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Team
    {
        public static int Sum(int[] h)
        {
            int s = 0;
            for (int i = 0; i < h.Length; i++)
                s += h[i];
            return s;
        }

        public static double Mean(int[] h)
        {
            int s = Sum(h);
            return (double)s / h.Length;
        }

        public static int Shortest(int[] h)
        {
            int m = h[0];
            for (int i = 1; i < h.Length; i++)
            {
                if (h[i] < m)
                    m = h[i];
            }
            return m;
        }

        public static int Tallest(int[] h)
        {
            int m = h[0];
            for (int i = 1; i < h.Length; i++)
            {
                if (h[i] > m)
                    m = h[i];
            }
            return m;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            int[] h = new int[11];
            Random r = new Random();

            for (int i = 0; i < h.Length; i++)
            {
                h[i] = r.Next(150, 251);
            }

            Console.WriteLine("Heights:");
            for (int i = 0; i < h.Length; i++)
                Console.WriteLine(h[i]);

            Console.WriteLine("Shortest = " + Team.Shortest(h));
            Console.WriteLine("Tallest = " + Team.Tallest(h));
            Console.WriteLine("Mean = " + Team.Mean(h));
        }
    }
}
