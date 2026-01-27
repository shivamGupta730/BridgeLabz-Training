using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class CustomObjectMapper
{
    static T ToObject<T>(Dictionary<string, object> data) where T : new()
    {
        T obj = new T();
        foreach (var item in data)
        {
            FieldInfo field = typeof(T).GetField(item.Key);
            field?.SetValue(obj, item.Value);
        }
        return obj;
    }

    static void Main()
    {
        var data = new Dictionary<string, object>()
        {
            { "Name", "Shivam" },
            { "Age", 22 }
        };

        User u = ToObject<User>(data);
        Console.WriteLine(u.Name + " " + u.Age);
    }
}
