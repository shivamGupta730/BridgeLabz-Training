using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        try
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            string age = Console.ReadLine();

            Console.Write("Favorite Language: ");
            string lang = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("userInfo.txt"))
            {
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Language: {lang}");
            }

            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
