using System;

public class Student
{
    // public – kahin se bhi access
    public int rollNumber;

    // protected – sirf class + child class
    protected string name;

    // private – sirf isi class me
    private double cgpa;

    // CGPA set karne ka method
    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }

    // CGPA lene ka method
    public double GetCGPA()
    {
        return cgpa;
    }

    // Name set karne ka method
    public void SetName(string name)
    {
        this.name = name;
    }
}

// Child class
public class PostgraduateStudent : Student
{
    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name); // protected access
    }
}

public class Program
{
    public static void Main()
    {
        PostgraduateStudent s = new PostgraduateStudent();

        Console.Write("Enter roll number: ");
        s.rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter name: ");
        s.SetName(Console.ReadLine());

        Console.Write("Enter CGPA: ");
        s.SetCGPA(Convert.ToDouble(Console.ReadLine()));

        s.DisplayStudent();
        Console.WriteLine("CGPA: " + s.GetCGPA());
    }
}
