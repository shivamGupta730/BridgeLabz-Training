using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.arrays.level1
{
    internal class TwoDToOneD
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[r, c];

            Console.WriteLine("Enter matrix elements:");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] arr = new int[r * c];
            int idx = 0;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[idx] = mat[i, j];
                    idx++;
                }
            }
             Console.WriteLine("1D Array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

