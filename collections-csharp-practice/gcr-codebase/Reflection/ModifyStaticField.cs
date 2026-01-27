using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class ModifyStaticField
{
    static void Main()
    {
        FieldInfo field = typeof(Configuration)
            .GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        field.SetValue(null, "NEW_KEY");
        Console.WriteLine("Updated Key: " + field.GetValue(null));
    }
}
