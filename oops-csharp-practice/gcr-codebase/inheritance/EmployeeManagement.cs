using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Manager : Employee
{
    public int TeamSize;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();

        Console.Write("Enter name: ");
        m.Name = Console.ReadLine();

        Console.Write("Enter id: ");
        m.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter salary: ");
        m.Salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter team size: ");
        m.TeamSize = Convert.ToInt32(Console.ReadLine());

        m.DisplayDetails();
    }
}
