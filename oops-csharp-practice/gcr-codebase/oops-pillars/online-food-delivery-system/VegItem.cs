class VegItem : FoodItem
{
    public VegItem(double p, int q)
    {
        price = p;
        quantity = q;
    }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }
}
