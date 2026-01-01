using System;

public class Vehicle
{
    // Instance variables
    private string ownerName;
    private string vehicleType;

    // Class variable
    public static double registrationFee;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }

    // Class method
    public static void UpdateRegistrationFee(double fee)
    {
        registrationFee = fee;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter registration fee: ");
        Vehicle.UpdateRegistrationFee(Convert.ToDouble(Console.ReadLine()));

        Console.Write("Enter owner name: ");
        string owner = Console.ReadLine();

        Console.Write("Enter vehicle type: ");
        string type = Console.ReadLine();

        Vehicle v = new Vehicle(owner, type);
        v.DisplayVehicleDetails();
    }
}
