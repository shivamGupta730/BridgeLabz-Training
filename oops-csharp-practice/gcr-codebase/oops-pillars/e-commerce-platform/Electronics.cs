class Electronics : Product, ITaxable
{
    public Electronics(double p)
    {
        price = p;
    }

    public override double CalculateDiscount()
    {
        return price * 0.10;
    }

    public double CalculateTax()
    {
        return price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "18% GST";
    }
}
