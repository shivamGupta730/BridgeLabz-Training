using System.IO;

public class FileProcessor
{
    public void WriteToFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
    }

    public string ReadFromFile(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}
