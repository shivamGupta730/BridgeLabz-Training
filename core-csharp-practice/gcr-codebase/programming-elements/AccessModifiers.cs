using System;

class Employee
{
    public string empName = "ABC";      // public variable
    private int salary = 28000;            // private variable
    protected int extraBonus = 1500;       // protected variable
    internal string orgName = "CDE"; // internal variable

    // private variable ko direct use nahi kar sakte
    // isliye method ke through print kiya
    public void PrintSalary()
    {
        Console.WriteLine("Salary is: " + salary);
    }
}

class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine("Employee Name: " + empName);
        Console.WriteLine("Bonus: " + extraBonus);
        Console.WriteLine("Organization: " + orgName);
    }
}

class Program
{
    static void Main()
    {
        Manager obj = new Manager();

        obj.ShowInfo();
        obj.PrintSalary();
    }
}
