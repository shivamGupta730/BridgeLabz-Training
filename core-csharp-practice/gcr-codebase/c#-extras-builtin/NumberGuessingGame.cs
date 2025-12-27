using System;

class NumberGuessingGame
{
    static void Main()
    {
        int low = 1;
        int high = 100;
        string feedback = "";

        Console.WriteLine("Think of a number between 1 and 100");
        Console.WriteLine("Type: high, low, or correct");

        while (feedback != "correct")
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("My guess is: " + guess);

            feedback = GetFeedback();

            if (feedback == "low")
                low = guess + 1;
            else if (feedback == "high")
                high = guess - 1;
        }

        Console.WriteLine("I guessed your number!");
    }

    static int GenerateGuess(int low, int high)
    {
        return (low + high) / 2;
    }

    static string GetFeedback()
    {
        return Console.ReadLine().ToLower();
    }
}
