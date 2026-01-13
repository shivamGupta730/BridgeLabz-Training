using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter element [" + i + "," + j + "]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("Enter target value: ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < rows; i++)
        {
            int low = 0;
            int high = cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (matrix[i, mid] == target)
                {
                    Console.WriteLine("Target found at row " + i + ", column " + mid);
                    found = true;
                    break;
                }
                else if (matrix[i, mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            if (found)
            {
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Target not found");
        }
    }
}
