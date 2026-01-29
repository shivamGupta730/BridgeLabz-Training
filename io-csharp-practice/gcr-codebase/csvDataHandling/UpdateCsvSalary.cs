using System.IO;

class UpdateCsvSalary
{
    static void Main()
    {
        using StreamReader sr = new StreamReader("employees.csv");
        using StreamWriter sw = new StreamWriter("updated_employees.csv");

        sw.WriteLine(sr.ReadLine()); // header

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            var d = line.Split(',');
            if (d[2] == "IT")
                d[3] = (int.Parse(d[3]) * 1.10).ToString();

            sw.WriteLine(string.Join(",", d));
        }
    }
}
