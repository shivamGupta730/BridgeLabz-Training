using System.IO;

class ReadLargeCsvInChunks
{
    static void Main()
    {
        using StreamReader sr = new StreamReader("students.csv");
        sr.ReadLine();

        int count = 0;
        while (!sr.EndOfStream)
        {
            for (int i = 0; i < 100 && !sr.EndOfStream; i++)
            {
                sr.ReadLine();
                count++;
            }
            System.Console.WriteLine($"Processed records: {count}");
        }
    }
}
