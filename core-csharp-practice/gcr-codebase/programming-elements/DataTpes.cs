using System;

class DataTypes
{
    static void Main()
    {
        // Original variables
        int num = 20;
        float value = 49.99f;
        double income = 45000.50;
        char grade = 'A';

        Console.WriteLine("Original Values:");
        Console.WriteLine(num);
        Console.WriteLine(value);
        Console.WriteLine(income);
        Console.WriteLine(grade);

        // ---------------- Typecasting ----------------
        Console.WriteLine("\nTypecasting Examples:");

        float numFloat = (float)num;         // int to float
        double numDouble = num;              // int to double (implicit)
        int incomeInt = (int)income;         // double to int
        int valueInt = (int)value;           // float to int
        int gradeInt = (int)grade;           // char to int

        Console.WriteLine("int to float: " + numFloat.ToString("0.0"));
        Console.WriteLine("int to double: " + numDouble);
        Console.WriteLine("double to int: " + incomeInt);
        Console.WriteLine("float to int: " + valueInt);
        Console.WriteLine("char to int: " + gradeInt);
    }
}
