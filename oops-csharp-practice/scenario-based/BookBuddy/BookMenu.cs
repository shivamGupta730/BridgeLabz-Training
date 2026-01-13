using System;

namespace BridgeLabzTraining.scenrio_based_problem.BookBuddy
{
    internal class BookMenu
    {
        private IBookService bookService = new BookUtility();

        public void ShowMenu()
        {
            bool running = true;

            while (running)
            {
                PrintMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBookMenu();
                        break;

                    case 2:
                        bookService.SortBooksAlphabetically();
                        break;

                    case 3:
                        SearchByAuthorMenu();
                        break;

                    case 4:
                        bookService.DisplayAllBooks();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Thank you for using BookBuddy.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\n=== BookBuddy – Digital Bookshelf App ===");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books Alphabetically");
            Console.WriteLine("3. Search By Author");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }

        private void AddBookMenu()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author name: ");
            string author = Console.ReadLine();

            bookService.AddBook(title, author);
        }

        private void SearchByAuthorMenu()
        {
            Console.Write("Enter author name to search: ");
            string author = Console.ReadLine();

            bookService.SearchByAuthor(author);
        }
    }
}
