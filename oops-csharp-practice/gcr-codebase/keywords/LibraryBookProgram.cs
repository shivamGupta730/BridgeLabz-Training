using System;

class LibraryBookProgram
{
    static string libraryName;

    string title;
    string author;
    readonly string isbn;

    LibraryBookProgram(string title, string author, string isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }

    void ShowBook(object obj)
    {
        if (obj is LibraryBookProgram)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }

    static void Main()
    {
        Console.Write("Enter Library Name: ");
        libraryName = Console.ReadLine();

        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();

        LibraryBookProgram book =
            new LibraryBookProgram(title, author, isbn);

        Console.WriteLine("Library: " + libraryName);
        book.ShowBook(book);
    }
}
