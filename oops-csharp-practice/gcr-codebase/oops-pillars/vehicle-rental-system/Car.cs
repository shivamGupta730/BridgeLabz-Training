class Car : Vehicle, IInsurable
{
    public Car(double rate)
    {
        rentalRate = rate;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance";
    }
}
