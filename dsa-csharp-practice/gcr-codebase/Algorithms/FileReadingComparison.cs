using System;
using System.IO;
using System.Text;

class FileReadingComparison
{
    static void Main()
    {
        // File path (change according to your system)
        string filePath = "largefile.txt";

        // -------- StreamReader --------
        DateTime startStreamReader = DateTime.Now;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1)
            {
                // reading character by character
            }
        }

        DateTime endStreamReader = DateTime.Now;
        double streamReaderTime =
            (endStreamReader - startStreamReader).TotalMilliseconds;

        // Output Time (Approx):
        // File Size = 1MB   -> ~50 ms
        // File Size = 100MB -> ~3000 ms (3 seconds)
        // File Size = 500MB -> ~10000 ms (10 seconds)

        // -------- FileStream --------
        DateTime startFileStream = DateTime.Now;

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024]; // 1KB buffer
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                // reading bytes
            }
        }

        DateTime endFileStream = DateTime.Now;
        double fileStreamTime =
            (endFileStream - startFileStream).TotalMilliseconds;

        // Output Time (Approx):
        // File Size = 1MB   -> ~30 ms
        // File Size = 100MB -> ~1500 ms (1.5 seconds)
        // File Size = 500MB -> ~5000 ms (5 seconds)

        Console.WriteLine("StreamReader Time (ms): " + streamReaderTime);
        Console.WriteLine("FileStream Time (ms): " + fileStreamTime);
    }
}
