class Book : LibraryItem, IReservable
{
    public Book(string t)
    {
        title = t;
    }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book Reserved");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}
