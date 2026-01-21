using System;
using System.Collections.Generic;

class FrequencyOfElements
{
    static void Main()
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();

        Console.Write("Enter number of strings: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter strings:");
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            if (freq.ContainsKey(s))
                freq[s]++;
            else
                freq[s] = 1;
        }

        Console.WriteLine("Frequency:");
        foreach (var pair in freq)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
