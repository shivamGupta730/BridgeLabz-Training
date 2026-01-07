abstract class FoodItem
{
    protected double price;
    protected int quantity;

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Price : " + price);
    }
}
