using System;

public class Employee
{
    // Employee ke attributes
    private string name;
    private int id;
    private double salary;

    // Constructor – user se aayi value set hogi
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Employee details show karne ka method
    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Object create kiya
        Employee emp = new Employee(name, id, salary);

        // Details print
        emp.DisplayDetails();
    }
}
