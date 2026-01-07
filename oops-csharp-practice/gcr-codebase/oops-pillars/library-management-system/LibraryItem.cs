abstract class LibraryItem
{
    protected string title;

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("Title : " + title);
    }
}
