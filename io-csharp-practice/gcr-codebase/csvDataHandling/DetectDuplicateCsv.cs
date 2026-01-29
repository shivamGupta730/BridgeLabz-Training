using System;
using System.Collections.Generic;
using System.IO;

class DetectDuplicateCsv
{
    static void Main()
    {
        HashSet<string> ids = new();

        foreach (var line in File.ReadLines("students.csv").Skip(1))
        {
            string id = line.Split(',')[0];
            if (!ids.Add(id))
                Console.WriteLine("Duplicate: " + line);
        }
    }
}
