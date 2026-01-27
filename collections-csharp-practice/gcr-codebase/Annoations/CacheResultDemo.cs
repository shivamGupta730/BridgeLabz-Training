using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Calculator
{
    static Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Square(int num)
    {
        if (cache.ContainsKey(num))
        {
            Console.WriteLine("From Cache");
            return cache[num];
        }

        Console.WriteLine("Calculating");
        int result = num * num;
        cache[num] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.Square(6));
        Console.WriteLine(c.Square(6));
    }
}
