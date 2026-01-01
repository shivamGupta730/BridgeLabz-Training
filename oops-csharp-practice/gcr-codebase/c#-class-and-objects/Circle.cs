using System;

public class Circle
{
    // Radius attribute
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Area calculate karne ka method
    public void ShowArea()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of Circle: " + area);
    }

    // Circumference calculate karne ka method
    public void ShowCircumference()
    {
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("Circumference of Circle: " + circumference);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Circle ka object
        Circle circle = new Circle(radius);

        circle.ShowArea();
        circle.ShowCircumference();
    }
}
