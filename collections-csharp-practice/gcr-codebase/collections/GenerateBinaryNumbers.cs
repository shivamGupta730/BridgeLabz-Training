using System;
using System.Collections.Generic;

class GenerateBinaryNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string s = q.Dequeue();
            Console.Write(s + " ");
            q.Enqueue(s + "0");
            q.Enqueue(s + "1");
        }
    }
}
