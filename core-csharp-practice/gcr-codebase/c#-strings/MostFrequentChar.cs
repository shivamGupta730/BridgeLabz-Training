using System;

class MostFrequentChar
{
    static void Main()
    {
        string str = Console.ReadLine();
        str = str.ToLower();

        int maxCount = 0;
        char maxChar = ' ';

        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxChar = str[i];
            }
        }

        Console.WriteLine(maxChar);
    }
}
