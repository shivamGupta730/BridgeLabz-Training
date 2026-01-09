using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.scenrio_based_problem.ATM
{
    internal class ATM
    {
        private LinkedList<int> denominations;
        private Dictionary<int, int> result;

        public ATM(int[] notes)
        {
            denominations = new LinkedList<int>();
            result = new Dictionary<int, int>();

            // store notes in descending order
            for (int i = notes.Length - 1; i >= 0; i--)
            {
                denominations.AddLast(notes[i]);
            }
        }

        public void DispenseCash(int amount)
        {
            result.Clear();
            int remaining = amount;

            foreach (int note in denominations)
            {
                if (remaining >= note)
                {
                    int count = remaining / note;
                    remaining = remaining % note;
                    result[note] = count;
                }
            }

            if (remaining == 0)
            {
                Console.WriteLine("Exact cash dispensed:");
            }
            else
            {
                Console.WriteLine("Exact amount not possible");
                Console.WriteLine("Fallback combination:");
            }

            DisplayResult();

            if (remaining != 0)
            {
                Console.WriteLine("Remaining amount: " + remaining);
            }
        }

        private void DisplayResult()
        {
            foreach (var item in result)
            {
                Console.WriteLine("Rs " + item.Key + " x " + item.Value);
            }
        }
    }
}
