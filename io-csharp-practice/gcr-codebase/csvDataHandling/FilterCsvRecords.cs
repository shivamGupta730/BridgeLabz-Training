using System.IO;

class FilterCsvRecords
{
    static void Main()
    {
        using StreamReader sr = new StreamReader("students.csv");
        sr.ReadLine();

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            var d = line.Split(',');
            if (int.Parse(d[3]) > 80)
                System.Console.WriteLine($"{d[1]} scored {d[3]}");
        }
    }
}
