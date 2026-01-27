using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; set; } = "MEDIUM";

    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
    }
}

class Project
{
    [Todo("Add login", "Amit")]
    [Todo("Improve UI", "Shivam", Priority = "HIGH")]
    public void Feature() { }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(Project).GetMethod("Feature");
        var todos = method.GetCustomAttributes<TodoAttribute>();

        foreach (var t in todos)
        {
            Console.WriteLine($"{t.Task} | {t.AssignedTo} | {t.Priority}");
        }
    }
}
