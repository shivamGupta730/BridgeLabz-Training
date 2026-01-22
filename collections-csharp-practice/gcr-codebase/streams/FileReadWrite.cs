using System;
using System.IO;

class FileReadWrite
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destPath = "destination.txt";

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                fsRead.CopyTo(fsWrite);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
