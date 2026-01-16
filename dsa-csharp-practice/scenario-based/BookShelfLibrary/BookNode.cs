using System;

namespace basic.BookShelfLibrary
{
    internal class BookNode
    {
        public string BookName;
        public BookNode Next;

        public BookNode(string bookName)
        {
            BookName = bookName;
            Next = null;
        }
    }
}
