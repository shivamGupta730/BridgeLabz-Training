using System;

class PalindromeChecker
{
    static void Main()
    {
        string text = ReadInput();

        if (IsPalindrome(text))
            ShowResult(true);
        else
            ShowResult(false);
    }

    static string ReadInput()
    {
        return Console.ReadLine().ToLower();
    }

    static bool IsPalindrome(string str)
    {
        int start = 0;
        int end = str.Length - 1;

        while (start < end)
        {
            if (str[start] != str[end])
                return false;

            start++;
            end--;
        }

        return true;
    }

    static void ShowResult(bool result)
    {
        if (result)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
