using System;

namespace MetalFactory
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter rod length: ");
            int rodLength = int.Parse(Console.ReadLine());

            Console.Write("Enter number of price entries: ");
            int n = int.Parse(Console.ReadLine());

            PipePricing pricing = new PipePricing(n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter pipe length: ");
                int length = int.Parse(Console.ReadLine());

                Console.Write("Enter price: ");
                int price = int.Parse(Console.ReadLine());

                pricing.AddPrice(length, price);
            }

            ICutStrategy optimized = new OptimizedCut(pricing);
            ICutStrategy nonOptimized = new NonOptimizedCut(pricing);

            Console.WriteLine("\nScenario A: Optimized Cut");
            optimized.CutPipe(rodLength);

            Console.WriteLine("\nScenario C: Non Optimized Cut");
            nonOptimized.CutPipe(rodLength);
        }
    }
}
