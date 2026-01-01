using System;

public class Person
{
    private string name;
    private int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Person p1 = new Person(name, age);
        Person p2 = new Person(p1);   // copy constructor

        Console.WriteLine("Copied Person Details:");
        p2.Display();
    }
}
