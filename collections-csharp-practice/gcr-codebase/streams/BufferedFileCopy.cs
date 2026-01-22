using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string source = "largefile.dat";
        string destBuffered = "bufferedCopy.dat";
        string destNormal = "normalCopy.dat";
        byte[] buffer = new byte[4096];

        Stopwatch sw = new Stopwatch();

        // Normal FileStream
        sw.Start();
        using (FileStream fsRead = new FileStream(source, FileMode.Open))
        using (FileStream fsWrite = new FileStream(destNormal, FileMode.Create))
        {
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                fsWrite.Write(buffer, 0, bytesRead);
        }
        sw.Stop();
        Console.WriteLine("Normal Stream Time: " + sw.ElapsedMilliseconds + " ms");

        // Buffered Stream
        sw.Restart();
        using (BufferedStream bsRead = new BufferedStream(new FileStream(source, FileMode.Open)))
        using (BufferedStream bsWrite = new BufferedStream(new FileStream(destBuffered, FileMode.Create)))
        {
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                bsWrite.Write(buffer, 0, bytesRead);
        }
        sw.Stop();
        Console.WriteLine("Buffered Stream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
