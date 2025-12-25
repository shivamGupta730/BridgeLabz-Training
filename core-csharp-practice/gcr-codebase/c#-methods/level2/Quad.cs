using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Quad
    {
        public static double[] Roots(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) + 4 * a * c;

            if (d > 0)
            {
                double r1 = (-b + Math.Sqrt(d)) / (2 * a);
                double r2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { r1, r2 };
            }
            else if (d == 0)
            {
                double r = -b / (2 * a);
                return new double[] { r };
            }
            else
            {
                return new double[0];
            }
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());

            double[] r = Quad.Roots(a, b, c);

            if (r.Length == 2)
            {
                Console.WriteLine("Root1 = " + r[0]);
                Console.WriteLine("Root2 = " + r[1]);
            }
            else if (r.Length == 1)
            {
                Console.WriteLine("Root = " + r[0]);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
