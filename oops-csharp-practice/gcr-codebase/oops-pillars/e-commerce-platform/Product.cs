abstract class Product
{
    private int productId;
    private string name;
    protected double price;

    public abstract double CalculateDiscount();

    public double GetPrice()
    {
        return price;
    }
}
