using System;

namespace MetalFactory
{
    class NonOptimizedCut : ICutStrategy
    {
        PipePricing pricing;

        public NonOptimizedCut(PipePricing pricing)
        {
            this.pricing = pricing;
        }

        public void CutPipe(int rodLength)
        {
            int[] prices = pricing.GetPrices();
            int revenue = rodLength * prices[0];

            Console.WriteLine("Cut all pipes of smallest size");
            Console.WriteLine("Non-Optimized Revenue = " + revenue);
        }
    }
}
