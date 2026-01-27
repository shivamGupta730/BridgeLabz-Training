using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service
{
    public void Run() => Console.WriteLine("Service running");
}

class Client
{
    [Inject]
    public Service service;
}

class SimpleDIReflection
{
    static void Main()
    {
        Client c = new Client();

        foreach (var field in typeof(Client).GetFields())
        {
            if (field.GetCustomAttribute<InjectAttribute>() != null)
            {
                field.SetValue(c, Activator.CreateInstance(field.FieldType));
            }
        }

        c.service.Run();
    }
}
