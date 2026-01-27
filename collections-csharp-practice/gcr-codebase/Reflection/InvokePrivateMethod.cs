using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class InvokePrivateMethod
{
    static void Main()
    {
        Calculator obj = new Calculator();
        MethodInfo method = typeof(Calculator)
            .GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(obj, new object[] { 3, 4 });
        Console.WriteLine("Result: " + result);
    }
}
