using System;
using System.Diagnostics;
using System.Reflection;

class Demo
{
    public void Work()
    {
        for (int i = 0; i < 1000000; i++) ;
    }
}

class MethodExecutionTiming
{
    static void Main()
    {
        Demo d = new Demo();
        MethodInfo method = typeof(Demo).GetMethod("Work");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(d, null);
        sw.Stop();

        Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds + " ms");
    }
}
