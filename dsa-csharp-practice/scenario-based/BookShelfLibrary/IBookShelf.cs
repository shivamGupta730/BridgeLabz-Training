using System;

namespace basic.BookShelfLibrary
{
    internal interface IBookShelf
    {
        void AddBook(string genre, string bookName);
        void BorrowBook(string genre, string bookName);
        void DisplayCatalog();
    }
}
