using System;

namespace BacktrackingDemo
{
    class PasswordCracker
    {
        static bool found = false;
        static string password;
        static char[] charset;

        static void Crack(string current, int length)
        {
            if (found) return;

            if (current.Length == length)
            {
                Console.WriteLine(current);
                if (current == password)
                {
                    Console.WriteLine("Password Cracked");
                    found = true;
                }
                return;
            }

            foreach (char ch in charset)
                Crack(current + ch, length);
        }

        static void Main()
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            Console.Write("Enter character set: ");
            charset = Console.ReadLine().ToCharArray();

            Crack("", password.Length);
        }
    }
}
