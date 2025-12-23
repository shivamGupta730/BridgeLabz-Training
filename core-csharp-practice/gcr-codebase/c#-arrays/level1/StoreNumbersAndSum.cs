using System;

namespace BridgeLabzTraining.arrays.level1
{
    internal class StoreNumbersAndSum
    {
        static void Main(string[] args)
        {
            // Array banaya jo maximum 10 numbers store karega
            double[] num = new double[10];

            // Total sum store karne ke liye variable
            double tot = 0.0;

            // Array ka index track karne ke liye
            int idx = 0;

            // Infinite loop user se input lene ke liye
            while (true)
            {
                Console.Write("Enter a number: ");
                double val = double.Parse(Console.ReadLine());

                // Agar user 0 ya negative number enter kare to loop stop
                if (val <= 0)
                {
                    break;
                }

                // Agar array full ho jaye (10 elements) to loop stop
                if (idx == 10)
                {
                    break;
                }

                // Valid number ko array me store kar rahe hain
                num[idx] = val;
                idx++;
            }

            // Array ke sab elements ka sum nikal rahe hain
            for (int i = 0; i < idx; i++)
            {
                tot = tot + num[i];
            }

            // Array me store kiye gaye numbers print kar rahe hain
            Console.WriteLine("\nNumbers entered:");
            for (int i = 0; i < idx; i++)
            {
                Console.WriteLine(num[i]);
            }

            // Final total print kar rahe hain
            Console.WriteLine("\nTotal sum = " + tot);
        }
    }
}
