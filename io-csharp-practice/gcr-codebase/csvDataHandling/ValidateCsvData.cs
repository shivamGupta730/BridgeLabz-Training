using System.IO;
using System.Text.RegularExpressions;

class ValidateCsvData
{
    static void Main()
    {
        Regex email = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phone = new(@"^\d{10}$");

        foreach (var line in File.ReadLines("data.csv").Skip(1))
        {
            var d = line.Split(',');
            if (!email.IsMatch(d[2]) || !phone.IsMatch(d[3]))
                System.Console.WriteLine("Invalid Row: " + line);
        }
    }
}
