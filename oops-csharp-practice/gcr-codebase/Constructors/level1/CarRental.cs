using System;

public class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    private double CalculateTotalCost()
    {
        double perDayCost = 1000;
        return perDayCost * rentalDays;
    }

    public void DisplayBill()
    {
        Console.WriteLine("Customer: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Days: " + rentalDays);
        Console.WriteLine("Total Cost: " + CalculateTotalCost());
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine();

        Console.Write("Enter car model: ");
        string model = Console.ReadLine();

        Console.Write("Enter rental days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        CarRental rental = new CarRental(name, model, days);
        rental.DisplayBill();
    }
}
