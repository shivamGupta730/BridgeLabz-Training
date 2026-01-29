using System.Collections.Generic;
using System.IO;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class CsvToStudentObject
{
    static void Main()
    {
        List<Student> list = new();

        foreach (var line in File.ReadLines("students.csv").Skip(1))
        {
            var d = line.Split(',');
            list.Add(new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2])
            });
        }

        foreach (var s in list)
            System.Console.WriteLine(s.Name);
    }
}
