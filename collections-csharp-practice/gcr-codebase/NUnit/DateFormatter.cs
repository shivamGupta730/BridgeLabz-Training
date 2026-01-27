using System;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        DateTime date = DateTime.Parse(inputDate);
        return date.ToString("dd-MM-yyyy");
    }
}
