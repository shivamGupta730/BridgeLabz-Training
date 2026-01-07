abstract class Vehicle
{
    protected double ratePerKm;

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Rate : " + ratePerKm);
    }
}
