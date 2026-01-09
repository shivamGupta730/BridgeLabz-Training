using System;
using System.Collections.Generic;

class CircularTour
{
    static void Main()
    {
        Console.Write("Enter number of petrol pumps: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] petrol = new int[n];
        int[] distance = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter petrol at pump " + i + ": ");
            petrol[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter distance to next pump: ");
            distance[i] = Convert.ToInt32(Console.ReadLine());
        }

        int start = 0, surplus = 0, deficit = 0;

        for (int i = 0; i < n; i++)
        {
            surplus += petrol[i] - distance[i];

            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        if (surplus + deficit >= 0)
            Console.WriteLine("Start from petrol pump index: " + start);
        else
            Console.WriteLine("No possible tour");
    }
}
