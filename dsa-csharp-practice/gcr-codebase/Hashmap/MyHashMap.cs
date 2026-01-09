using System;
using System.Collections.Generic;

class MyHashMap
{
    private const int SIZE = 10;
    private LinkedList<KeyValuePair<int, int>>[] table;

    public MyHashMap()
    {
        table = new LinkedList<KeyValuePair<int, int>>[SIZE];
        for (int i = 0; i < SIZE; i++)
            table[i] = new LinkedList<KeyValuePair<int, int>>();
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    // Insert
    public void Put(int key, int value)
    {
        int index = Hash(key);

        foreach (var pair in table[index])
        {
            if (pair.Key == key)
            {
                table[index].Remove(pair);
                break;
            }
        }

        table[index].AddLast(new KeyValuePair<int, int>(key, value));
    }

    // Get
    public int Get(int key)
    {
        int index = Hash(key);

        foreach (var pair in table[index])
        {
            if (pair.Key == key)
                return pair.Value;
        }

        return -1; // not found
    }

    // Remove
    public void Remove(int key)
    {
        int index = Hash(key);

        foreach (var pair in table[index])
        {
            if (pair.Key == key)
            {
                table[index].Remove(pair);
                return;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap();
        int choice, key, value;

        do
        {
            Console.WriteLine("\n1. Insert");
            Console.WriteLine("2. Get");
            Console.WriteLine("3. Remove");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter key: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter value: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    map.Put(key, value);
                    break;

                case 2:
                    Console.Write("Enter key: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Value: " + map.Get(key));
                    break;

                case 3:
                    Console.Write("Enter key: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    map.Remove(key);
                    break;
            }
        }
        while (choice != 4);
    }
}
