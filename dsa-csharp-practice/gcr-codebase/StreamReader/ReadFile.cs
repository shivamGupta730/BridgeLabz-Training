using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        StreamReader reader = new StreamReader(path);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        reader.Close();
    }
}
