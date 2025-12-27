using System;

class RemoveChar
{
    static void Main()
    {
        string str = Console.ReadLine();
        char ch = Console.ReadLine()[0];

        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ch)
            {
                result += str[i];
            }
        }

        Console.WriteLine(result);
    }
}
