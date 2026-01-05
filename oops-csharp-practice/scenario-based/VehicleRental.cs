using System;

namespace OOPS_VehicleRental
{
    // Interface for rental calculation
    interface IRentable
    {
        double CalculateRent(int days);
    }

    // Base class Vehicle
    class Vehicle
    {
        protected string VehicleNumber;   // protected field
        protected double RentPerDay;

        public Vehicle(string number, double rent)
        {
            VehicleNumber = number;
            RentPerDay = rent;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Vehicle Number: " + VehicleNumber);
        }
    }

    // Bike class
    class Bike : Vehicle, IRentable
    {
        public Bike(string number, double rent) : base(number, rent) { }

        public double CalculateRent(int days)
        {
            return days * RentPerDay;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Type: Bike");
        }
    }

    // Car class
    class Car : Vehicle, IRentable
    {
        public Car(string number, double rent) : base(number, rent) { }

        public double CalculateRent(int days)
        {
            return days * RentPerDay;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Type: Car");
        }
    }

    // Truck class
    class Truck : Vehicle, IRentable
    {
        public Truck(string number, double rent) : base(number, rent) { }

        public double CalculateRent(int days)
        {
            return days * RentPerDay;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Type: Truck");
        }
    }

    class Program
    {
        static void Main()
        {
            IRentable bike = new Bike("BIKE123", 300);
            IRentable car = new Car("CAR456", 1000);
            IRentable truck = new Truck("TRUCK789", 2000);

            Console.WriteLine("Bike Rent for 3 days: " + bike.CalculateRent(3));
            Console.WriteLine("Car Rent for 2 days: " + car.CalculateRent(2));
            Console.WriteLine("Truck Rent for 1 day: " + truck.CalculateRent(1));
        }
    }
}
