using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                foreach (string word in line.Split(' ', ',', '.', ';'))
                {
                    if (string.IsNullOrWhiteSpace(word)) continue;

                    string w = word.ToLower();
                    if (!words.ContainsKey(w))
                        words[w] = 0;
                    words[w]++;
                }
            }
        }

        foreach (var item in words.OrderByDescending(x => x.Value).Take(5))
            Console.WriteLine($"{item.Key} : {item.Value}");
    }
}
