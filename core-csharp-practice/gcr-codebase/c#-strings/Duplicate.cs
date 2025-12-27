using System;

class Duplicate
{
    static void Main()
    {
        string str = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(str))
        {
            Console.WriteLine("String is empty");
            return;
        }

        str = str.ToLower();
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            char current = str[i];
            bool found = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == current)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                result += current;
            }
        }

        Console.WriteLine(result);
    }
}
