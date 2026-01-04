using System;

class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Speed: " + MaxSpeed);
        Console.WriteLine("Fuel: " + FuelType);
    }
}

class Car : Vehicle
{
    public int SeatCapacity;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seats: " + SeatCapacity);
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Car();

        Console.Write("Enter max speed: ");
        v.MaxSpeed = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fuel type: ");
        v.FuelType = Console.ReadLine();

        Console.Write("Enter seat capacity: ");
        ((Car)v).SeatCapacity = Convert.ToInt32(Console.ReadLine());

        v.DisplayInfo();
    }
}
