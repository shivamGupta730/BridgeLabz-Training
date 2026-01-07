class Car : Vehicle
{
    public Car()
    {
        ratePerKm = 12;
    }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }
}
