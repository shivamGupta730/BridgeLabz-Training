using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class FormatString
    {
        static void Main(string[] args)
        {
            // User se string input lene ke liye
            Console.WriteLine("Enter the String");
            String str = Console.ReadLine();

            // Pehle extra spaces remove karne ke liye formater method call
            string res = formater(str);

            // Ab capital letter aur punctuation handle karne ke liye
            string result = CapitalAndPunctuation(res);

            // Final formatted string print kar rahe hain
            Console.WriteLine(result);
        }

        // Yeh method string me se extra spaces hata deta hai
        // Aur words ke beech sirf ek space rakhta hai
        internal static string formater(string str)
        {
            // Space ke basis par string ko split kar rahe hain
            char[] mid = new char[] { ' ' };
            String[] output = str.Split(mid);

            string result = "";
            bool found = false; // Yeh check karega pehla word mila ya nahi

            for (int i = 0; i < output.Length; i++)
            {
                // Agar empty string hai toh skip kar do (extra spaces ki wajah se)
                if (output[i] == "")
                {
                    continue;
                }
                else
                {
                    // Pehle word se pehle space nahi lagate
                    if (found == false)
                    {
                        result += output[i];
                        found = true; // Pehla word mil gaya
                    }
                    else
                    {
                        // First word ke baad har word se pehle ek space add karte hain
                        result += " " + output[i];
                    }
                }
            }
            return result;
        }

        // Yeh method sentence ke first letter ko capital banata hai
        // Aur punctuation ke baad space aur capital letter handle karta hai
        internal static string CapitalAndPunctuation(string str)
        {
            string empty = "";     // Final output string
            bool isCapital = true; // Start me first letter capital hoga

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i]; // Current character ko store kar rahe hain

                // Agar sentence start hai aur letter lowercase hai
                if (isCapital == true && (ch >= 'a' && ch <= 'z'))
                {
                    // ASCII use karke lowercase ko uppercase me convert kar rahe hain
                    ch = (char)(ch - 32);
                    empty += ch;
                    isCapital = false; // Capital ho gaya, next normal letters
                }
                else
                {
                    // Baaki characters ko as it is add kar dete hain
                    empty += ch;
                }

                // Agar punctuation mila toh next sentence ke liye capital set kar do
                if (ch == '.' || ch == '?' || ch == '!')
                {
                    isCapital = true;

                    // Agar punctuation ke baad space nahi hai toh ek space add kar do
                    if (i + 1 < str.Length && str[i + 1] != ' ')
                    {
                        empty += ' ';
                    }
                }
            }
            return empty;
        }
    }
}
