using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Line
    {
        public static double Dist(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        public static double[] Eq(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;
            return new double[] { m, b };
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2:");
            double y2 = double.Parse(Console.ReadLine());

            double d = Line.Dist(x1, y1, x2, y2);
            double[] r = Line.Eq(x1, y1, x2, y2);

            Console.WriteLine("Distance = " + d);
            Console.WriteLine("Line Equation: y = " + r[0] + "x + " + r[1]);
        }
    }
}
