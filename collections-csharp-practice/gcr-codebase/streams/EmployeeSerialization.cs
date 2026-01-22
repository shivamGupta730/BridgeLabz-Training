using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string file = "employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee{Id=1, Name="Amit", Department="IT", Salary=50000},
            new Employee{Id=2, Name="Riya", Department="HR", Salary=45000}
        };

        try
        {
            string json = JsonSerializer.Serialize(employees);
            File.WriteAllText(file, json);

            string readJson = File.ReadAllText(file);
            List<Employee> empList = JsonSerializer.Deserialize<List<Employee>>(readJson);

            foreach (var e in empList)
                Console.WriteLine($"{e.Id} {e.Name} {e.Department} {e.Salary}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
