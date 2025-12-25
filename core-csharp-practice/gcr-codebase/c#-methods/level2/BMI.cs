using System;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class BMI
    {
        public static void Cal(double[,] a)
        {
            for (int i = 0; i < 10; i++)
            {
                double w = a[i, 0];
                double h = a[i, 1] / 100;
                a[i, 2] = w / (h * h);
            }
        }

        public static string[] Status(double[,] a)
        {
            string[] s = new string[10];

            for (int i = 0; i < 10; i++)
            {
                double b = a[i, 2];

                if (b <= 18.4)
                    s[i] = "Underweight";
                else if (b <= 24.9)
                    s[i] = "Normal";
                else if (b <= 39.9)
                    s[i] = "Overweight";
                else
                    s[i] = "Obese";
            }
            return s;
        }
    }

    internal class Prog
    {
        static void Main(string[] args)
        {
            double[,] a = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter weight (kg):");
                a[i, 0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter height (cm):");
                a[i, 1] = double.Parse(Console.ReadLine());
            }

            BMI.Cal(a);
            string[] s = BMI.Status(a);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(
                    "Weight=" + a[i, 0] +
                    " Height=" + a[i, 1] +
                    " BMI=" + a[i, 2] +
                    " Status=" + s[i]
                );
            }
        }
    }
}
