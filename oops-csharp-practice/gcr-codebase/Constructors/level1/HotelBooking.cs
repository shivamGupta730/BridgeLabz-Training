using System;

public class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "";
        roomType = "";
        nights = 0;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking hb)
    {
        guestName = hb.guestName;
        roomType = hb.roomType;
        nights = hb.nights;
    }

    public void Display()
    {
        Console.WriteLine("Guest: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter guest name: ");
        string name = Console.ReadLine();

        Console.Write("Enter room type: ");
        string room = Console.ReadLine();

        Console.Write("Enter nights: ");
        int nights = Convert.ToInt32(Console.ReadLine());

        HotelBooking hb1 = new HotelBooking(name, room, nights);
        HotelBooking hb2 = new HotelBooking(hb1);

        hb2.Display();
    }
}
