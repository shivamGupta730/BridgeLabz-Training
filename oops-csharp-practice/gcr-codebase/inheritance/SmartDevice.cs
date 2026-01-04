using System;

class Device
{
    public int DeviceId;
    public string Status;
}

class Thermostat : Device
{
    public int TemperatureSetting;

    public void DisplayStatus()
    {
        Console.WriteLine("Device Id: " + DeviceId);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine("Temperature: " + TemperatureSetting);
    }
}

class Program
{
    static void Main()
    {
        Thermostat t = new Thermostat();

        Console.Write("Enter device id: ");
        t.DeviceId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter status: ");
        t.Status = Console.ReadLine();

        Console.Write("Enter temperature: ");
        t.TemperatureSetting = Convert.ToInt32(Console.ReadLine());

        t.DisplayStatus();
    }
}
