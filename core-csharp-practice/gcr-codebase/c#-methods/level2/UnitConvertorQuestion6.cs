using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class UnitConvertor
    {
        public static double FToC(double f)
        {
            double r = (f - 32) * 5 / 9;
            return r;
        }

        public static double CToF(double c)
        {
            double r = (c * 9 / 5) + 32;
            return r;
        }

        public static double LbToKg(double lb)
        {
            double k = 0.453592;
            return lb * k;
        }

        public static double KgToLb(double kg)
        {
            double k = 2.20462;
            return kg * k;
        }

        public static double GalToL(double g)
        {
            double k = 3.78541;
            return g * k;
        }

        public static double LToGal(double l)
        {
            double k = 0.264172;
            return l * k;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit:");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.FToC(f));

            Console.WriteLine("Enter Celsius:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.CToF(c));

            Console.WriteLine("Enter pounds:");
            double lb = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.LbToKg(lb));

            Console.WriteLine("Enter kilograms:");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.KgToLb(kg));

            Console.WriteLine("Enter gallons:");
            double g = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.GalToL(g));

            Console.WriteLine("Enter liters:");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.LToGal(l));
        }
    }
}
