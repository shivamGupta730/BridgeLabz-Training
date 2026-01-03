using System;

class EmployeeProgram
{
    static string companyName;
    static int totalEmployees = 0;

    string name;
    string designation;
    readonly int id;

    EmployeeProgram(string name, int id, string designation)
    {
        this.name = name;
        this.id = id;
        this.designation = designation;
        totalEmployees++;
    }

    static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    void ShowEmployee(object obj)
    {
        if (obj is EmployeeProgram)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + designation);
        }
    }

    static void Main()
    {
        Console.Write("Enter Company Name: ");
        companyName = Console.ReadLine();

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Designation: ");
        string desig = Console.ReadLine();

        EmployeeProgram emp =
            new EmployeeProgram(name, id, desig);

        Console.WriteLine("Company: " + companyName);
        emp.ShowEmployee(emp);
        DisplayTotalEmployees();
    }
}
