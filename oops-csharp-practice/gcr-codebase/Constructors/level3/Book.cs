using System;

public class Book
{
    public string ISBN;
    protected string title;
    private string author;

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }
}

// Child class
public class EBook : Book
{
    public void DisplayBook()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
    }
}

public class Program
{
    public static void Main()
    {
        EBook book = new EBook();

        Console.Write("Enter ISBN: ");
        book.ISBN = Console.ReadLine();

        Console.Write("Enter title: ");
        book.SetTitle(Console.ReadLine());

        Console.Write("Enter author: ");
        book.SetAuthor(Console.ReadLine());

        book.DisplayBook();
        Console.WriteLine("Author: " + book.GetAuthor());
    }
}
