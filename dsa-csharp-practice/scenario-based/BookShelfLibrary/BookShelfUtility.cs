using System;

namespace basic.BookShelfLibrary
{
    internal class BookShelfUtility : IBookShelf
    {
        string[] genres = new string[5];
        BookNode[] heads = new BookNode[5];
        int count = 0;

        public void AddBook(string genre, string bookName)
        {
            int index = FindOrCreateGenre(genre);

            BookNode temp = heads[index];
            while (temp != null)
            {
                if (temp.BookName == bookName)
                {
                    Console.WriteLine("Book already exists");
                    return;
                }
                temp = temp.Next;
            }

            BookNode newNode = new BookNode(bookName);
            newNode.Next = heads[index];
            heads[index] = newNode;

            Console.WriteLine("Added book: " + bookName);
        }

        public void BorrowBook(string genre, string bookName)
        {
            int index = FindGenre(genre);
            if (index == -1)
            {
                Console.WriteLine("Genre not found");
                return;
            }

            BookNode temp = heads[index];
            BookNode prev = null;

            while (temp != null)
            {
                if (temp.BookName == bookName)
                {
                    if (prev == null)
                        heads[index] = temp.Next;
                    else
                        prev.Next = temp.Next;

                    Console.WriteLine("Borrowed book: " + bookName);
                    return;
                }

                prev = temp;
                temp = temp.Next;
            }

            Console.WriteLine("Book not available");
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("\nLibrary Catalog:");

            for (int i = 0; i < count; i++)
            {
                Console.Write(genres[i] + " -> ");
                BookNode temp = heads[i];

                while (temp != null)
                {
                    Console.Write(temp.BookName + " , ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }

        // ---------- Helper ----------
        int FindGenre(string genre)
        {
            for (int i = 0; i < count; i++)
            {
                if (genres[i] == genre)
                    return i;
            }
            return -1;
        }

        int FindOrCreateGenre(string genre)
        {
            int index = FindGenre(genre);
            if (index != -1)
                return index;

            genres[count] = genre;
            heads[count] = null;
            return count++;
        }
    }
}
