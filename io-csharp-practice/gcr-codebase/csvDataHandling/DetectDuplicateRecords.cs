using System.Collections.Generic;
using System.IO;
using System.Linq;

class DetectDuplicateRecords
{
    static void Main()
    {
        HashSet<string> ids = new();

        foreach (var line in File.ReadLines("students.csv").Skip(1))
        {
            var id = line.Split(',')[0];
            if (!ids.Add(id))
                System.Console.WriteLine("Duplicate: " + line);
        }
    }
}
