using System;

public class Circle
{
    private double radius;

    // Default constructor → chaining
    public Circle() : this(1)
    {
    }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void ShowArea()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of Circle: " + area);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle c = new Circle(radius);
        c.ShowArea();
    }
}
