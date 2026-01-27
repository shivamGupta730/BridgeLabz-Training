using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== HealthCheckPro – API Metadata Validator ===\n");

        ApiMetadataScanner.ScanControllers();

        Console.ReadLine();
    }
}
