using System;

class ReplaceWord
{
    static void Main()
    {
        string s = Console.ReadLine();
        string oldW = Console.ReadLine();
        string newW = Console.ReadLine();

        string[] arr = s.Split(' ');
        string res = "";

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == oldW)
                res += newW;
            else
                res += arr[i];

            res += " ";
        }

        Console.WriteLine(res);
    }
}
