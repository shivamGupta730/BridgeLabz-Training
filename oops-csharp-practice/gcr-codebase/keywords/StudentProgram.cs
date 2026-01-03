using System;

class StudentProgram
{
    static string universityName;
    static int totalStudents = 0;

    string name;
    string grade;
    readonly int rollNumber;

    StudentProgram(string name, int rollNumber, string grade)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.grade = grade;
        totalStudents++;
    }

    static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    void ShowStudent(object obj)
    {
        if (obj is StudentProgram)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Grade: " + grade);
        }
    }

    static void Main()
    {
        Console.Write("Enter University Name: ");
        universityName = Console.ReadLine();

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine();

        StudentProgram stu =
            new StudentProgram(name, roll, grade);

        Console.WriteLine("University: " + universityName);
        stu.ShowStudent(stu);
        DisplayTotalStudents();
    }
}
