using System;
using System.IO;

class ReadCsvAndPrint
{
    static void Main()
    {
        using StreamReader sr = new StreamReader("students.csv");
        sr.ReadLine(); // skip header

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] d = line.Split(',');
            Console.WriteLine($"ID:{d[0]} Name:{d[1]} Age:{d[2]} Marks:{d[3]}");
        }
    }
}
