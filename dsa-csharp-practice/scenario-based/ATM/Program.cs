using System;

namespace BridgeLabzTraining.scenrio_based_problem.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount to withdraw: ");
            int amount = int.Parse(Console.ReadLine());

            // Scenario A: All notes available
            Console.WriteLine("\n--- Scenario A: All Notes Available ---");
            int[] notesA = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            ATM atmA = new ATM(notesA);
            atmA.DispenseCash(amount);

            // Scenario B: 500 note removed
            Console.WriteLine("\n--- Scenario B: 500 Note Removed ---");
            int[] notesB = { 1, 2, 5, 10, 20, 50, 100, 200 };
            ATM atmB = new ATM(notesB);
            atmB.DispenseCash(amount);

            // Scenario C: No small notes (fallback case)
            Console.WriteLine("\n--- Scenario C: No 1 & 2 Notes (Fallback) ---");
            int[] notesC = { 5, 10, 20, 50, 100, 200, 500 };
            ATM atmC = new ATM(notesC);
            atmC.DispenseCash(amount);

            Console.ReadLine();
        }
    }
}
