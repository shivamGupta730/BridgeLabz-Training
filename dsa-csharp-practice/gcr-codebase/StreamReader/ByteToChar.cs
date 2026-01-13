using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fs);

        int ch;

        while ((ch = reader.Read()) != -1)
        {
            Console.Write((char)ch);
        }

        reader.Close();
        fs.Close();
    }
}
