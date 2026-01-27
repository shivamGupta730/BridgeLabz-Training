using System;
using System.Reflection;

class Person
{
    private int age = 20;
}

class AccessPrivateField
{
    static void Main()
    {
        Person p = new Person();
        FieldInfo field = typeof(Person)
            .GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(p, 25);
        Console.WriteLine("Age: " + field.GetValue(p));
    }
}
