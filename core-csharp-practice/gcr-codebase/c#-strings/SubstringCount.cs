using System;

class SubstringCount
{
    static void Main()
    {
        string text = Console.ReadLine();
        string sub = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            string part = text.Substring(i, sub.Length);

            if (part == sub)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
