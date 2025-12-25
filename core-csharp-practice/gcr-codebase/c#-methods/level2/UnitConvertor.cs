using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class UnitConvertor
    {
        public static double KmToMiles(double km)
        {
            double k = 0.621371;
            return km * k;
        }

        public static double MilesToKm(double m)
        {
            double k = 1.60934;
            return m * k;
        }

        public static double MToFeet(double m)
        {
            double k = 3.28084;
            return m * k;
        }

        public static double FeetToM(double f)
        {
            double k = 0.3048;
            return f * k;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter km:");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.KmToMiles(km));

            Console.WriteLine("Enter miles:");
            double mi = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.MilesToKm(mi));

            Console.WriteLine("Enter meters:");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.MToFeet(m));

            Console.WriteLine("Enter feet:");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine(UnitConvertor.FeetToM(f));
        }
    }
}
