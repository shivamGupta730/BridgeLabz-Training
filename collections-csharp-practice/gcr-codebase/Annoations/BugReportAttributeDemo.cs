using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class Application
{
    [BugReport("Login bug")]
    [BugReport("Crash on submit")]
    public void Run() { }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(Application).GetMethod("Run");
        var bugs = method.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute bug in bugs)
        {
            Console.WriteLine(bug.Description);
        }
    }
}
