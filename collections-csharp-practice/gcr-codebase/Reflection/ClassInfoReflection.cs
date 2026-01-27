using System;
using System.Reflection;

class Sample
{
    public int x;
    private string name;

    public Sample() { }
    public void Hello() { }
    private void Secret() { }
}

class ClassInfoReflection
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (var m in type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(m.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (var f in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(f.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (var c in type.GetConstructors())
        {
            Console.WriteLine(c);
        }
    }
}
