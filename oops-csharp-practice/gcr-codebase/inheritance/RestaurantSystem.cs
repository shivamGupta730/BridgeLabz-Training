using System;

interface Worker
{
    void PerformDuties();
}

class Person
{
    public string Name;
    public int Id;
}

class Chef : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Chef is cooking");
    }
}

class Program
{
    static void Main()
    {
        Chef c = new Chef();

        Console.Write("Enter name: ");
        c.Name = Console.ReadLine();

        Console.Write("Enter id: ");
        c.Id = Convert.ToInt32(Console.ReadLine());

        c.PerformDuties();
    }
}
