using System;

public class Book
{
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        title = "";
        author = "";
        price = 0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Book book = new Book(title, author, price);
        book.DisplayDetails();
    }
}
