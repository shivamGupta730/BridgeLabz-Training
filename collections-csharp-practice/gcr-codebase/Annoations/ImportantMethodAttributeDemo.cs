using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; set; } = "HIGH";
}

class Demo
{
    [ImportantMethod]
    public void MethodOne() { }

    [ImportantMethod(Level = "LOW")]
    public void MethodTwo() { }
}

class Program
{
    static void Main()
    {
        foreach (var method in typeof(Demo).GetMethods())
        {
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
                Console.WriteLine(method.Name + " - " + attr.Level);
        }
    }
}
