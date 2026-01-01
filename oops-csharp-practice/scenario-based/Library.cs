using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class Library
    {
        static void Main(string[] args)
        {
            Library obj = new Library();

            // Books already stored (minimum 10)
            string[,] books = obj.StoredBooks();
            int count = books.GetLength(0);

            // Show only Title + Author (no status)
            obj.DisplayBookNames(books, count);

            // Search and checkout (status shown here)
            obj.SearchAndUpdateStatus(books, count);

            Console.WriteLine("\nProgram Ended.");
        }

        // Books already stored
        string[,] StoredBooks()
        {
            string[,] books = new string[10, 3];

            books[0, 0] = "Java Programming";
            books[0, 1] = "James Gosling";
            books[0, 2] = "Available";

            books[1, 0] = "C Sharp Basics";
            books[1, 1] = "Microsoft";
            books[1, 2] = "Available";

            books[2, 0] = "Data Structures";
            books[2, 1] = "Mark Allen";
            books[2, 2] = "Checked Out";

            books[3, 0] = "Operating Systems";
            books[3, 1] = "Abraham Silberschatz";
            books[3, 2] = "Available";

            books[4, 0] = "Database Management System";
            books[4, 1] = "Raghu Ramakrishnan";
            books[4, 2] = "Available";

            books[5, 0] = "Computer Networks";
            books[5, 1] = "Andrew Tanenbaum";
            books[5, 2] = "Checked Out";

            books[6, 0] = "Python Programming";
            books[6, 1] = "Guido van Rossum";
            books[6, 2] = "Available";

            books[7, 0] = "Machine Learning Basics";
            books[7, 1] = "Tom Mitchell";
            books[7, 2] = "Available";

            books[8, 0] = "Artificial Intelligence";
            books[8, 1] = "Stuart Russell";
            books[8, 2] = "Checked Out";

            books[9, 0] = "Software Engineering";
            books[9, 1] = "Ian Sommerville";
            books[9, 2] = "Available";

            return books;
        }

        // Display ONLY book name and author
        void DisplayBookNames(string[,] books, int count)
        {
            Console.WriteLine("\n--- Library Books (Name & Author) ---");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i, 0] + " - " + books[i, 1]);
            }
        }

        // Search and checkout (status shown here)
        void SearchAndUpdateStatus(string[,] books, int count)
        {
            Console.WriteLine("\nEnter book title to search:");
            string search = Console.ReadLine();

            // Edge case: empty input
            if (string.IsNullOrWhiteSpace(search))
            {
                Console.WriteLine("Search input cannot be empty.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (books[i, 0].ToLower().Contains(search.ToLower()))
                {
                    Console.WriteLine("\nBook Found:");
                    Console.WriteLine("Title  : " + books[i, 0]);
                    Console.WriteLine("Author : " + books[i, 1]);
                    Console.WriteLine("Status : " + books[i, 2]);

                    if (books[i, 2] == "Checked Out")
                    {
                        Console.WriteLine("This book is already checked out.");
                        return;
                    }

                    Console.WriteLine("Do you want to checkout this book? (yes/no)");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "yes")
                    {
                        books[i, 2] = "Checked Out";
                        Console.WriteLine("Book checked out successfully.");
                        return;
                    }
                    else if (choice.ToLower() == "no")
                    {
                        Console.WriteLine("Checkout cancelled.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        return;
                    }
                }
            }

            Console.WriteLine("Book not found in library.");
        }
    }
}
