using System;

class LongestWord
{
    static void Main()
    {
        string s = Console.ReadLine();

        string[] arr = s.Split(' ');
        string longWord = "";

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > longWord.Length)
            {
                longWord = arr[i];
            }
        }

        Console.WriteLine(longWord);
    }
}
