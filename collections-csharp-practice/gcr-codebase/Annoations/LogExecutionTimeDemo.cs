using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Service
{
    [LogExecutionTime]
    public void DoWork()
    {
        Stopwatch sw = Stopwatch.StartNew();
        System.Threading.Thread.Sleep(400);
        sw.Stop();

        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}

class Program
{
    static void Main()
    {
        new Service().DoWork();
    }
}
