using System;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BMI2DArray
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            double[][] pd = new double[n][];
            string[] ws = new string[n];

            for (int i = 0; i < n; i++)
                pd[i] = new double[3];

            for (int i = 0; i < n; i++)
            {
                pd[i][0] = Convert.ToDouble(Console.ReadLine());
                if (pd[i][0] <= 0) { i--; continue; }

                pd[i][1] = Convert.ToDouble(Console.ReadLine());
                if (pd[i][1] <= 0) { i--; continue; }
            }

            for (int i = 0; i < n; i++)
            {
                pd[i][2] = pd[i][0] / (pd[i][1] * pd[i][1]);

                if (pd[i][2] <= 18.4) ws[i] = "Underweight";
                else if (pd[i][2] <= 24.9) ws[i] = "Normal";
                else if (pd[i][2] <= 39.9) ws[i] = "Overweight";
                else ws[i] = "Obese";
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine(pd[i][1] + "," + pd[i][0] + "," + pd[i][2] + "," + ws[i]);
        }
    }
}
