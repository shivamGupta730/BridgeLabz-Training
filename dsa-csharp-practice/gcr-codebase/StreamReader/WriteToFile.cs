using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path to save text: ");
        string path = Console.ReadLine();

        Console.WriteLine("Enter text (type END to stop):");

        StreamWriter writer = new StreamWriter(path);

        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            writer.WriteLine(input);
        }

        writer.Close();

        Console.WriteLine("Data saved in file successfully.");
    }
}
