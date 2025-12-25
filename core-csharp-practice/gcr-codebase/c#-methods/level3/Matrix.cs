using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Matrix
    {
        public static int[,] Gen(int r, int c)
        {
            int[,] a = new int[r, c];
            Random rd = new Random();

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    a[i, j] = rd.Next(1, 10);

            return a;
        }

        public static int[,] Add(int[,] a, int[,] b)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int[,] s = new int[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    s[i, j] = a[i, j] + b[i, j];

            return s;
        }

        public static int[,] Sub(int[,] a, int[,] b)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int[,] s = new int[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    s[i, j] = a[i, j] - b[i, j];

            return s;
        }

        public static int[,] Mul(int[,] a, int[,] b)
        {
            int r1 = a.GetLength(0);
            int c1 = a.GetLength(1);
            int c2 = b.GetLength(1);

            int[,] m = new int[r1, c2];

            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    m[i, j] = 0;
                    for (int k = 0; k < c1; k++)
                        m[i, j] += a[i, k] * b[k, j];
                }
            }
            return m;
        }

        public static int[,] Trans(int[,] a)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int[,] t = new int[c, r];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    t[j, i] = a[i, j];

            return t;
        }

        public static int Det2x2(int[,] a)
        {
            return (a[0, 0] * a[1, 1]) - (a[0, 1] * a[1, 0]);
        }

        public static double[,] Inv2x2(int[,] a)
        {
            int d = Det2x2(a);
            double[,] inv = new double[2, 2];

            inv[0, 0] = a[1, 1] / (double)d;
            inv[0, 1] = -a[0, 1] / (double)d;
            inv[1, 0] = -a[1, 0] / (double)d;
            inv[1, 1] = a[0, 0] / (double)d;

            return inv;
        }

        public static void Show(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public static void ShowD(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(Math.Round(a[i, j], 2) + "\t");
                Console.WriteLine();
            }
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            int[,] a = Matrix.Gen(2, 2);
            int[,] b = Matrix.Gen(2, 2);

            Console.WriteLine("Matrix A");
            Matrix.Show(a);

            Console.WriteLine("Matrix B");
            Matrix.Show(b);

            Console.WriteLine("Addition");
            Matrix.Show(Matrix.Add(a, b));

            Console.WriteLine("Subtraction");
            Matrix.Show(Matrix.Sub(a, b));

            Console.WriteLine("Multiplication");
            Matrix.Show(Matrix.Mul(a, b));

            Console.WriteLine("Transpose of A");
            Matrix.Show(Matrix.Trans(a));

            int d = Matrix.Det2x2(a);
            Console.WriteLine("Determinant of A = " + d);

            if (d != 0)
            {
                Console.WriteLine("Inverse of A");
                Matrix.ShowD(Matrix.Inv2x2(a));
            }
            else
            {
                Console.WriteLine("Inverse not possible");
            }
        }
    }
}
