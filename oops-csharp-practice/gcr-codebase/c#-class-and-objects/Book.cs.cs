using System;

public class Book
{
    // Book ke attributes
    private string title;
    private string author;
    private double price;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Book details print karne ka method
    public void DisplayDetails()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        // Book object
        Book book = new Book(title, author, price);

        book.DisplayDetails();
    }
}
