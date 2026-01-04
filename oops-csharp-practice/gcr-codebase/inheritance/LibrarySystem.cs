using System;

class Book
{
    public string Title;
    public int PublicationYear;
}

class Author : Book
{
    public string Name;
    public string Bio;

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Year: " + PublicationYear);
        Console.WriteLine("Author: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author();

        Console.Write("Enter book title: ");
        a.Title = Console.ReadLine();

        Console.Write("Enter publication year: ");
        a.PublicationYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter author name: ");
        a.Name = Console.ReadLine();

        Console.Write("Enter author bio: ");
        a.Bio = Console.ReadLine();

        a.DisplayInfo();
    }
}
