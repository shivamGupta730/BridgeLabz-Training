using System;

namespace oops.selfPractice
{
    class BusRoute
    {
        // Predefined Mathura stops
        public string[] stops =
        {
            "Mathura Junction",
            "Krishna Janmabhoomi",
            "Dwarkadhish Temple",
            "Vishram Ghat",
            "Govardhan Chauraha",
            "Vrindavan",
            "Prem Mandir",
            "ISKCON Temple",
            "Barsana Road",
            "Govardhan"
        };
    }

    internal class BusRouteTracker
    {
        public static void Main(string[] args)
        {
            BusRoute bus = new BusRoute();

            int start, end;
            int distancePerStop;
            int totalDistance;
            int totalPrice;

            int ratePerKm = 10;   //  FIXED RATE

            Console.WriteLine("Available Bus Stops:\n");
            for (int i = 0; i < bus.stops.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + bus.stops[i]);
            }

            // Starting stop
            while (true)
            {
                Console.Write("\nEnter starting stop number: ");
                if (!int.TryParse(Console.ReadLine(), out start) ||
                    start < 1 || start > bus.stops.Length)
                {
                    Console.WriteLine("Invalid starting stop. Try again.");
                    continue;
                }
                break;
            }

            // Ending stop
            while (true)
            {
                Console.Write("Enter ending stop number: ");
                if (!int.TryParse(Console.ReadLine(), out end) ||
                    end < 1 || end > bus.stops.Length || end <= start)
                {
                    Console.WriteLine("Invalid ending stop. Ending stop must be after starting stop.");
                    continue;
                }
                break;
            }

            // Distance per stop (user defined)
            while (true)
            {
                Console.Write("Enter distance between each stop (in km): ");
                if (!int.TryParse(Console.ReadLine(), out distancePerStop) ||
                    distancePerStop <= 0)
                {
                    Console.WriteLine("Invalid distance. Enter a positive value.");
                    continue;
                }
                break;
            }

            // Calculations
            totalDistance = (end - start) * distancePerStop;
            totalPrice = totalDistance * ratePerKm;

            Console.WriteLine("\nJourney Details:");
            Console.WriteLine("From: " + bus.stops[start - 1]);
            Console.WriteLine("To: " + bus.stops[end - 1]);
            Console.WriteLine("Total Distance: " + totalDistance + " km");
            Console.WriteLine("Rate per km: Rs " + ratePerKm);
            Console.WriteLine("Total Ticket Price: Rs " + totalPrice);
        }
    }
}
