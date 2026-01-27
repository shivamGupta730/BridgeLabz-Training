using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    FileProcessor processor;
    string fileName;

    [SetUp]
    public void Setup()
    {
        processor = new FileProcessor();
        fileName = "testfile.txt";
    }

    [TearDown]
    public void TearDown()
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
    }

    [Test]
    public void WriteAndRead_File_Test()
    {
        processor.WriteToFile(fileName, "Hello World");

        string result = processor.ReadFromFile(fileName);

        Assert.AreEqual("Hello World", result);
    }

    [Test]
    public void File_Should_Exist_After_Write()
    {
        processor.WriteToFile(fileName, "Test");

        Assert.IsTrue(File.Exists(fileName));
    }

    [Test]
    public void Read_File_Not_Exist_Should_Throw_Exception()
    {
        Assert.Throws<FileNotFoundException>(() =>
        {
            processor.ReadFromFile("nofile.txt");
        });
    }
}
