using System;

namespace basic.BookShelfLibrary
{
    internal class BookShelfMenu
    {
        IBookShelf shelf = new BookShelfUtility();

        public void Start()
        {
            int choice;

            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter book name: ");
                        string book = Console.ReadLine();
                        shelf.AddBook(genre, book);
                        break;

                    case 2:
                        Console.Write("Enter genre: ");
                        string g = Console.ReadLine();
                        Console.Write("Enter book name: ");
                        string b = Console.ReadLine();
                        shelf.BorrowBook(g, b);
                        break;

                    case 3:
                        shelf.DisplayCatalog();
                        break;
                }

            } while (choice != 4);
        }

        void ShowMenu()
        {
            Console.WriteLine("\n--- Book Shelf Menu ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Display Catalog");
            Console.WriteLine("4. Exit");
        }
    }
}
