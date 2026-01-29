using System.IO;
using System.Linq;

class SortCsvBySalary
{
    static void Main()
    {
        var data = File.ReadLines("employees.csv")
            .Skip(1)
            .Select(l => l.Split(','))
            .OrderByDescending(d => int.Parse(d[3]))
            .Take(5);

        foreach (var d in data)
            System.Console.WriteLine($"{d[1]} {d[3]}");
    }
}
