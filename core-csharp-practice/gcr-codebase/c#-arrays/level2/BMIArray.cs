using System;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BMIArray
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            double[] wt = new double[n];
            double[] ht = new double[n];
            double[] bmi = new double[n];
            string[] st = new string[n];

            for (int i = 0; i < n; i++)
            {
                wt[i] = Convert.ToDouble(Console.ReadLine());
                if (wt[i] <= 0) { i--; continue; }

                ht[i] = Convert.ToDouble(Console.ReadLine());
                if (ht[i] <= 0) { i--; continue; }
            }

            for (int i = 0; i < n; i++)
            {
                bmi[i] = wt[i] / (ht[i] * ht[i]);

                if (bmi[i] <= 18.4) st[i] = "Underweight";
                else if (bmi[i] <= 24.9) st[i] = "Normal";
                else if (bmi[i] <= 39.9) st[i] = "Overweight";
                else st[i] = "Obese";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ht[i] + "," + wt[i] + "," + bmi[i] + "," + st[i]);
            }
        }
    }
}
