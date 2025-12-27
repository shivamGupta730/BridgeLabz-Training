using System;

class AnagramCheck
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        s1 = s1.ToLower();
        s2 = s2.ToLower();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagram");
            return;
        }

        int count = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            for (int j = 0; j < s2.Length; j++)
            {
                if (s1[i] == s2[j])
                {
                    count++;
                    break;
                }
            }
        }

        if (count == s1.Length)
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not Anagram");
    }
}
