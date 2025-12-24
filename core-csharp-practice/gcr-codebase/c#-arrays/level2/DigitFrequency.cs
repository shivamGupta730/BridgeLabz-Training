using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class DigitFrequency
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int count = 0;

            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            int[] digits = new int[count];
            int[] freq = new int[10];

            temp = num;
            for (int i = 0; i < count; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            for (int i = 0; i < count; i++)
            {
                freq[digits[i]]++;
            }

            for (int i = 0; i < 10; i++)
            {
                if (freq[i] > 0)
                    Console.WriteLine(i + "->" + freq[i]);
            }
        }
    }
}
