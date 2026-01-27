using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

[Author("Shivam Gupta")]
class DemoClass { }

class CustomAttributeReflection
{
    static void Main()
    {
        AuthorAttribute attr =
            (AuthorAttribute)Attribute.GetCustomAttribute(
                typeof(DemoClass), typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attr.Name);
    }
}
