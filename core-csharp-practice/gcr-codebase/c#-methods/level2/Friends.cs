using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Friends
    {
        public static int Youngest(int[] a)
        {
            int m = a[0];
            int idx = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < m)
                {
                    m = a[i];
                    idx = i;
                }
            }
            return idx;
        }

        public static int Tallest(double[] h)
        {
            double m = h[0];
            int idx = 0;

            for (int i = 1; i < h.Length; i++)
            {
                if (h[i] > m)
                {
                    m = h[i];
                    idx = i;
                }
            }
            return idx;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            string[] n = { "Amar", "Akbar", "Anthony" };
            int[] a = new int[3];
            double[] h = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter age of " + n[i] + ":");
                a[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter height of " + n[i] + ":");
                h[i] = double.Parse(Console.ReadLine());
            }

            int y = Friends.Youngest(a);
            int t = Friends.Tallest(h);

            Console.WriteLine("Youngest: " + n[y]);
            Console.WriteLine("Tallest: " + n[t]);
        }
    }
}
