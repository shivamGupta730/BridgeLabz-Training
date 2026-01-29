using System.IO;
using System.Linq;

class MergeCsvFiles
{
    static void Main()
    {
        var s1 = File.ReadLines("students1.csv").Skip(1)
            .Select(l => l.Split(','))
            .ToDictionary(d => d[0]);

        using StreamWriter sw = new("merged.csv");
        sw.WriteLine("ID,Name,Age,Marks,Grade");

        foreach (var line in File.ReadLines("students2.csv").Skip(1))
        {
            var d = line.Split(',');
            sw.WriteLine($"{d[0]},{s1[d[0]][1]},{s1[d[0]][2]},{d[1]},{d[2]}");
        }
    }
}
