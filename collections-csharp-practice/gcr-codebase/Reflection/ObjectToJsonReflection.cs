using System;
using System.Reflection;
using System.Text;

class Person
{
    public string Name = "Aman";
    public int Age = 21;
}

class ObjectToJsonReflection
{
    static void Main()
    {
        Person p = new Person();
        StringBuilder json = new StringBuilder("{");

        foreach (var f in typeof(Person).GetFields())
        {
            json.Append($"\"{f.Name}\":\"{f.GetValue(p)}\",");
        }

        json.Length--;
        json.Append("}");

        Console.WriteLine(json);
    }
}
