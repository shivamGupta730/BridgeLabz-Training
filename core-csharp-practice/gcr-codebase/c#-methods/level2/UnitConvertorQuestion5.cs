using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class UnitConvertorQuestion5
    {
        public static double YardsToFeet(double y)
        {
            double k = 3;
            return y * k;
        }

        public static double FeetToYards(double f)
        {
            double k = 0.333333;
            return f * k;
        }

        public static double MToInches(double m)
        {
            double k = 39.3701;
            return m * k;
        }

        public static double InchesToM(double i)
        {
            double k = 0.0254;
            return i * k;
        }

        public static double InchesToCm(double i)
        {
            double k = 2.54;
            return i * k;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yards:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.YardsToFeet(y));

            Console.WriteLine("Enter feet:");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.FeetToYards(f));

            Console.WriteLine("Enter meters:");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.MToInches(m));

            Console.WriteLine("Enter inches:");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.InchesToM(i));

            Console.WriteLine(UnitConvertor.InchesToCm(i));
        }
    }
}
