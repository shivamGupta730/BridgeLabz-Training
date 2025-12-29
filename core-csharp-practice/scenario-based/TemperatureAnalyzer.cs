using System;

class TemperatureAnalyzer
{
    static void Main()
    {
        // 7 days aur har din ke 24 hours ka temperature
        float[,] temp = new float[7, 24];

        // ----------- INPUT TEMPERATURE -----------
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("Enter temperatures for Day " + (day + 1));

            for (int hour = 0; hour < 24; hour++)
            {
                temp[day, hour] = Convert.ToSingle(Console.ReadLine());
            }
        }

        // ----------- HOTTEST & COLDEST DAY -----------
        float maxTemp = temp[0, 0];
        float minTemp = temp[0, 0];
        int hotDay = 0;
        int coldDay = 0;

        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                if (temp[day, hour] > maxTemp)
                {
                    maxTemp = temp[day, hour];
                    hotDay = day;
                }

                if (temp[day, hour] < minTemp)
                {
                    minTemp = temp[day, hour];
                    coldDay = day;
                }
            }
        }

        Console.WriteLine("Hottest Day = Day " + (hotDay + 1));
        Console.WriteLine("Coldest Day = Day " + (coldDay + 1));

        // ----------- AVERAGE TEMPERATURE PER DAY -----------
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                sum = sum + temp[day, hour];
            }

            float average = sum / 24;
            Console.WriteLine("Average temperature of Day " + (day + 1) + " = " + average);
        }
    }
}
