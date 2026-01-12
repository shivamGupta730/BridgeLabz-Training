using System;

namespace MetalFactory
{
    class OptimizedCut : ICutStrategy
    {
        PipePricing pricing;

        public OptimizedCut(PipePricing pricing)
        {
            this.pricing = pricing;
        }

        public void CutPipe(int rodLength)
        {
            int revenue = 0;
            int[] lengths = pricing.GetLengths();
            int[] prices = pricing.GetPrices();
            int count = pricing.GetCount();

            Console.Write("Cuts: ");

            for (int i = count - 1; i >= 0; i--)
            {
                int pieces = rodLength / lengths[i];
                revenue += pieces * prices[i];
                rodLength %= lengths[i];

                for (int j = 0; j < pieces; j++)
                    Console.Write(lengths[i] + " ");
            }

            Console.WriteLine("\nOptimized Revenue = " + revenue);
        }
    }
}
