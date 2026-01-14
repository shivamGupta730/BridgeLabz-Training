using System;
using System.Text;

class StringConcatenationComparison
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int n in sizes)
        {
            Console.WriteLine("\nOperations Count: " + n);

            // -------- Using string (Immutable) --------
            DateTime startString = DateTime.Now;

            string s = "";
            for (int i = 0; i < n; i++)
            {
                s = s + "a";
            }

            DateTime endString = DateTime.Now;
            double stringTime =
                (endString - startString).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000     -> ~10 ms
            // N = 10,000    -> ~1000 ms (1 second)
            // N = 1,000,000 -> ~30 minutes (Unusable)

            // -------- Using StringBuilder (Mutable) --------
            DateTime startBuilder = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("a");
            }

            DateTime endBuilder = DateTime.Now;
            double builderTime =
                (endBuilder - startBuilder).TotalMilliseconds;

            // Output Time (Approx):
            // N = 1,000     -> ~1 ms
            // N = 10,000    -> ~10 ms
            // N = 1,000,000 -> ~50 ms

            Console.WriteLine("string Time (ms): " + stringTime);
            Console.WriteLine("StringBuilder Time (ms): " + builderTime);
        }
    }
}
