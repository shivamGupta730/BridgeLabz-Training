using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Score
    {
        public static int[,] Gen(int n)
        {
            int[,] m = new int[n, 3];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                m[i, 0] = r.Next(10, 100);
                m[i, 1] = r.Next(10, 100);
                m[i, 2] = r.Next(10, 100);
            }
            return m;
        }

        public static double[,] Calc(int[,] m)
        {
            int n = m.GetLength(0);
            double[,] r = new double[n, 3];

            for (int i = 0; i < n; i++)
            {
                double t = m[i, 0] + m[i, 1] + m[i, 2];
                double a = t / 3;
                double p = (t / 300) * 100;

                r[i, 0] = Math.Round(t, 2);
                r[i, 1] = Math.Round(a, 2);
                r[i, 2] = Math.Round(p, 2);
            }
            return r;
        }

        public static void Show(int[,] m, double[,] r)
        {
            int n = m.GetLength(0);

            Console.WriteLine("Phy\tChem\tMath\tTotal\tAvg\tPer");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    m[i, 0] + "\t" +
                    m[i, 1] + "\t" +
                    m[i, 2] + "\t" +
                    r[i, 0] + "\t" +
                    r[i, 1] + "\t" +
                    r[i, 2]
                );
            }
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students:");
            int n = int.Parse(Console.ReadLine());

            int[,] m = Score.Gen(n);
            double[,] r = Score.Calc(m);
            Score.Show(m, r);
        }
    }
}
