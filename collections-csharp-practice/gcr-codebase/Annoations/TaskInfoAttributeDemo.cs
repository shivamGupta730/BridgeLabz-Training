using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("HIGH", "Shivam")]
    public void CompleteTask() { }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute info =
            (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));

        Console.WriteLine("Priority: " + info.Priority);
        Console.WriteLine("Assigned To: " + info.AssignedTo);
    }
}
