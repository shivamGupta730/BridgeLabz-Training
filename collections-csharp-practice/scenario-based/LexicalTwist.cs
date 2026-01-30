using System;
using System.Text;
using System.Collections.Generic;

class LexicalTwist
{
    static void Main()
    {
        Console.WriteLine("Enter the first word");
        string firstWord = Console.ReadLine();

        // Validation for first word
        if (firstWord.Contains(" "))
        {
            Console.WriteLine($"{firstWord} is an invalid word");
            return;
        }

        Console.WriteLine("Enter the second word");
        string secondWord = Console.ReadLine();

        // Validation for second word
        if (secondWord.Contains(" "))
        {
            Console.WriteLine($"{secondWord} is an invalid word");
            return;
        }

        // Reverse first word using StringBuilder
        StringBuilder reverseBuilder = new StringBuilder();
        for (int i = firstWord.Length - 1; i >= 0; i--)
        {
            reverseBuilder.Append(firstWord[i]);
        }

        string reversedFirst = reverseBuilder.ToString();

        // Check if second word is reverse (case-insensitive)
        if (reversedFirst.Equals(secondWord, StringComparison.OrdinalIgnoreCase))
        {
            // Step 1 & 2: lowercase
            StringBuilder result = new StringBuilder(reversedFirst.ToLower());

            // Step 3: replace vowels with '@'
            for (int i = 0; i < result.Length; i++)
            {
                if ("aeiou".Contains(result[i]))
                {
                    result[i] = '@';
                }
            }

            // Step 4: print transformed word
            Console.WriteLine(result.ToString());
        }
        else
        {
            // Combine words
            StringBuilder combinedBuilder = new StringBuilder();
            combinedBuilder.Append(firstWord);
            combinedBuilder.Append(secondWord);

            string combined = combinedBuilder.ToString().ToUpper();

            int vowelCount = 0, consonantCount = 0;

            // Count vowels and consonants
            foreach (char c in combined)
            {
                if ("AEIOU".Contains(c))
                    vowelCount++;
                else if (char.IsLetter(c))
                    consonantCount++;
            }

            // Decision based on counts
            if (vowelCount > consonantCount)
            {
                PrintFirstTwoDistinct(combined, true);
            }
            else if (consonantCount > vowelCount)
            {
                PrintFirstTwoDistinct(combined, false);
            }
            else
            {
                Console.WriteLine("Vowels and consonants are equal");
            }
        }
    }

    static void PrintFirstTwoDistinct(string word, bool vowelsNeeded)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder output = new StringBuilder();

        foreach (char c in word)
        {
            if (vowelsNeeded && "AEIOU".Contains(c) && !seen.Contains(c))
            {
                output.Append(c);
                seen.Add(c);
            }
            else if (!vowelsNeeded && !"AEIOU".Contains(c) && char.IsLetter(c) && !seen.Contains(c))
            {
                output.Append(c);
                seen.Add(c);
            }

            if (output.Length == 2)
                break;
        }

        Console.WriteLine(output.ToString());
    }
}
