using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class Collinear
    {
        public static bool BySlope(double x1, double y1,
                                   double x2, double y2,
                                   double x3, double y3)
        {
            double m1 = (y2 - y1) / (x2 - x1);
            double m2 = (y3 - y2) / (x3 - x2);
            double m3 = (y3 - y1) / (x3 - x1);

            return (m1 == m2 && m2 == m3);
        }

        public static bool ByArea(double x1, double y1,
                                  double x2, double y2,
                                  double x3, double y3)
        {
            double area = 0.5 * (
                x1 * (y2 - y3) +
                x2 * (y3 - y1) +
                x3 * (y1 - y2)
            );

            return area == 0;
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

            Console.WriteLine("Enter x3:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y3:");
            double y3 = double.Parse(Console.ReadLine());

            bool s = Collinear.BySlope(x1, y1, x2, y2, x3, y3);
            bool a = Collinear.ByArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("Collinear using slope = " + s);
            Console.WriteLine("Collinear using area = " + a);
        }
    }
}
