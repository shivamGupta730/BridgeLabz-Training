using System.IO;

class SearchCsvRecord
{
    static void Main()
    {
        string searchName = "Rahul";

        using StreamReader sr = new StreamReader("employees.csv");
        sr.ReadLine();

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            var d = line.Split(',');
            if (d[1].Equals(searchName))
            {
                System.Console.WriteLine($"Dept: {d[2]}, Salary: {d[3]}");
                break;
            }
        }
    }
}
