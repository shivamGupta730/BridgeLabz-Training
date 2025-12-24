using System;

namespace BridgeLabzTraining.arrays.level2
{
    internal class FriendsAgeHeightQuestion
    {
        static void Main()
        {
            string[] n = { "Amar", "Akbar", "Anthony" };
            int[] a = new int[3];
            double[] h = new double[3];

            for (int i = 0; i < 3; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                h[i] = Convert.ToDouble(Console.ReadLine());
            }

            int yi = 0;
            int ti = 0;

            for (int i = 1; i < 3; i++)
            {
                if (a[i] < a[yi]) yi = i;
                if (h[i] > h[ti]) ti = i;
            }

            Console.WriteLine(n[yi]);
            Console.WriteLine(n[ti]);
        }
    }
}
