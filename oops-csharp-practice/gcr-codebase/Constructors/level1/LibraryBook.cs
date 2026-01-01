using System;

public class LibraryBook
{
    private string title;
    private string author;
    private double price;
    private bool available;

    public LibraryBook(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        available = true;
    }

    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed successfully");
        }
        else
        {
            Console.WriteLine("Book not available");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author: ");
        string author = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        LibraryBook book = new LibraryBook(title, author, price);
        book.BorrowBook();
    }
}
