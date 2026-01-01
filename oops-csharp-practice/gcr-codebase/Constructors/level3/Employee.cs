using System;

public class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetDepartment(string dept)
    {
        department = dept;
    }
}

// Child class
public class Manager : Employee
{
    public void DisplayManager()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
    }
}

public class Program
{
    public static void Main()
    {
        Manager m = new Manager();

        Console.Write("Enter employee ID: ");
        m.employeeID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter department: ");
        m.SetDepartment(Console.ReadLine());

        Console.Write("Enter salary: ");
        m.SetSalary(Convert.ToDouble(Console.ReadLine()));

        m.DisplayManager();
        Console.WriteLine("Salary: " + m.GetSalary());
    }
}
