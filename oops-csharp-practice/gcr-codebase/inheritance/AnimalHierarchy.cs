using System;

class Animal
{
    public string Name;
    public int Age;

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter animal type (dog/cat/bird): ");
        string type = Console.ReadLine().ToLower();

        Animal a;

        if (type == "dog")
            a = new Dog();
        else if (type == "cat")
            a = new Cat();
        else
            a = new Bird();

        Console.Write("Enter name: ");
        a.Name = Console.ReadLine();

        Console.Write("Enter age: ");
        a.Age = Convert.ToInt32(Console.ReadLine());

        a.MakeSound();
    }
}
