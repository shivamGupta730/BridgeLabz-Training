using System;

namespace BridgeLabzTraining.scenrio_based_problem.BookBuddy
{
    public interface IBookService
    {
        void AddBook(string title, string author);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
        void DisplayAllBooks();
    }
}
