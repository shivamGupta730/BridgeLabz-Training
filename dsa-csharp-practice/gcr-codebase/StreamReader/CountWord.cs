using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        Console.Write("Enter word to count: ");
        string word = Console.ReadLine();

        int count = 0;

        StreamReader reader = new StreamReader(path);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    count++;
                }
            }
        }

        reader.Close();

        Console.WriteLine("Word count: " + count);
    }
}
