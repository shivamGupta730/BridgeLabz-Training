using System;

class VehicleRegistrationProgram
{
    static double registrationFee;

    string ownerName;
    string vehicleType;
    readonly string registrationNumber;

    VehicleRegistrationProgram(string ownerName, string vehicleType, string registrationNumber)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.registrationNumber = registrationNumber;
    }

    void ShowVehicle(object obj)
    {
        if (obj is VehicleRegistrationProgram)
        {
            Console.WriteLine("Owner: " + ownerName);
            Console.WriteLine("Vehicle Type: " + vehicleType);
        }
    }

    static void Main()
    {
        Console.Write("Enter Registration Fee: ");
        registrationFee = double.Parse(Console.ReadLine());

        Console.Write("Enter Owner Name: ");
        string owner = Console.ReadLine();

        Console.Write("Enter Vehicle Type: ");
        string type = Console.ReadLine();

        Console.Write("Enter Registration Number: ");
        string regNo = Console.ReadLine();

        VehicleRegistrationProgram vehicle =
            new VehicleRegistrationProgram(owner, type, regNo);

        Console.WriteLine("Fee: " + registrationFee);
        vehicle.ShowVehicle(vehicle);
    }
}
