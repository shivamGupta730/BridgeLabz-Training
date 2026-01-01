using System;

public class Course
{
    // Instance variables
    private string courseName;
    private int duration;
    private double fee;

    // Class variable
    public static string instituteName;

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fee);
    }

    // Class method
    public static void UpdateInstituteName(string name)
    {
        instituteName = name;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter institute name: ");
        Course.UpdateInstituteName(Console.ReadLine());

        Console.Write("Enter course name: ");
        string cname = Console.ReadLine();

        Console.Write("Enter duration (months): ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter course fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Course course = new Course(cname, duration, fee);
        course.DisplayCourseDetails();
    }
}
