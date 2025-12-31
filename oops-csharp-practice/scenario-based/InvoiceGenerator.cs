using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class InvoiceGenerator
    {
        // Method: invoice string ko tasks me todna
        string[] ParseInvoice(string input)
        {
            // comma ke basis par split
            string[] tasks = input.Split(',');
            return tasks;
        }

        // Method: total amount calculate karna
        int GetTotalAmount(string[] tasks)
        {
            int total = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                // Example: "Logo Design - 3000 INR"
                string[] parts = tasks[i].Split('-');

                // " 3000 INR"
                string amountPart = parts[1];

                // space se split karke number nikalna
                string[] amountArray = amountPart.Split(' ');

                int amount = Convert.ToInt32(amountArray[1]);
                total = total + amount;
            }

            return total;
        }

        // Main Method
        static void Main(string[] args)
        {
            InvoiceGenerator obj = new InvoiceGenerator();

            Console.WriteLine("Enter invoice details:");
            Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");
            string input = Console.ReadLine();

            // Parse invoice
            string[] tasks = obj.ParseInvoice(input);

            Console.WriteLine("\nInvoice Tasks:");
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }

            // Calculate total
            int totalAmount = obj.GetTotalAmount(tasks);
            Console.WriteLine("\nTotal Invoice Amount: " + totalAmount + " INR");
        }
    }
}
