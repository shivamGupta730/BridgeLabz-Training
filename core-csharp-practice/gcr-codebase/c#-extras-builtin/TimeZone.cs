using System;

class TimeZone
{
    static void Main()
    {
        DateTimeOffset time = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        Console.WriteLine(TimeZoneInfo.ConvertTime(time, gmt));
        Console.WriteLine(TimeZoneInfo.ConvertTime(time, ist));
        Console.WriteLine(TimeZoneInfo.ConvertTime(time, pst));
    }
}
