using System;

class Student
{
    public Student()
    {
        Console.WriteLine("Student object created");
    }
}

class DynamicObjectCreation
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);
    }
}
