using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class StringScene
    {
        static void Main(string[] args)
        {
            // User se poora paragraph / sentence input lena
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            // Class ka object banaya (kyunki methods static nahi hain)
            StringScene obj = new StringScene();

            // ---------------- WORD COUNT ----------------
            // Kitne words hain uska count
            int wc = obj.wordCount(str);
            Console.WriteLine("Word Count : " + wc);

            // ---------------- LONGEST WORD ----------------
            // Sentence me sabse lamba word kaunsa hai
            string lw = obj.longestWord(str);
            Console.WriteLine("Longest Word : " + lw);

            // ---------------- REPLACE WORD ----------------
            // User se pooch rahe hain kaunsa word replace karna hai
            Console.WriteLine("Enter word to replace");
            string oldWord = Console.ReadLine();

            // User se pooch rahe hain naya word kya hoga
            Console.WriteLine("Enter new word");
            string newWord = Console.ReadLine();

            // Replace method call
            string rep = obj.replaceWord(str, oldWord, newWord);
            Console.WriteLine("After Replace : " + rep);
        }

        // =====================================================
        // METHOD 1 : WORD COUNT
        // =====================================================
        private int wordCount(string str)
        {
            // Agar string null ya empty hai toh koi word nahi
            if (string.IsNullOrEmpty(str))
                return 0;

            // Check kar rahe hain ki string me koi letter hai bhi ya nahi
            bool valid = false;
            for (int i = 0; i < str.Length; i++)
            {
                // Agar space ke alawa kuch mila
                if (str[i] != ' ')
                {
                    valid = true;
                    break; // ek bhi letter mil gaya toh bas
                }
            }

            // Agar sirf spaces hi the
            if (!valid)
                return 0;

            int count = 0;

            // Character by character string traverse
            for (int i = 0; i < str.Length; i++)
            {
                // Word tab start hota hai jab:
                // 1. current char space nahi ho
                // 2. ya toh string ka first char ho
                //    ya previous char space ho
                if (str[i] != ' ' && (i == 0 || str[i - 1] == ' '))
                {
                    count++; // naya word mila
                }
            }

            return count;
        }

        // =====================================================
        // METHOD 2 : LONGEST WORD
        // =====================================================
        private string longestWord(string str)
        {
            // Agar string empty hai toh longest word bhi empty
            if (string.IsNullOrEmpty(str))
                return "";

            string cur = "";      // jo word abhi ban raha hai
            string longest = ""; // ab tak ka sabse lamba word

            // Poori string char by char read kar rahe hain
            for (int i = 0; i < str.Length; i++)
            {
                // Agar space nahi hai toh word banta ja raha hai
                if (str[i] != ' ')
                {
                    cur += str[i];
                }
                else
                {
                    // Space mila matlab ek word complete
                    // Ab compare karte hain length
                    if (cur.Length > longest.Length)
                        longest = cur;

                    // Next word ke liye reset
                    cur = "";
                }
            }

            // Last word ka special case
            // Kyunki last word ke baad space nahi hota
            if (cur.Length > longest.Length)
                longest = cur;

            return longest;
        }

        // =====================================================
        // METHOD 3 : REPLACE WORD (CASE INSENSITIVE)
        // =====================================================
        private string replaceWord(string str, string oldWord, string newWord)
        {
            // Empty string case
            if (string.IsNullOrEmpty(str))
                return "";

            string cur = ""; // current word
            string ans = ""; // final answer string

            // Character by character loop
            for (int i = 0; i < str.Length; i++)
            {
                // Agar space nahi hai toh word banta rahe
                if (str[i] != ' ')
                {
                    cur += str[i];
                }
                else
                {
                    // Word complete hua
                    // Case-insensitive comparison
                    if (cur.ToLower() == oldWord.ToLower())
                        ans += newWord; // replace
                    else
                        ans += cur;     // as it is

                    ans += " "; // space wapas add
                    cur = "";   // next word ke liye reset
                }
            }

            // Last word handle (space nahi hota end me)
            if (cur != "")
            {
                if (cur.ToLower() == oldWord.ToLower())
                    ans += newWord;
                else
                    ans += cur;
            }

            return ans;
        }
    }
}
