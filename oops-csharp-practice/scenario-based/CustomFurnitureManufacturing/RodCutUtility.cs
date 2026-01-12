using System;

namespace CustomFurnitureManufacturing
{
    class RodCutUtility : ICutStrategy
    {
        RodPricing pricing;

        public RodCutUtility(RodPricing pricing)
        {
            this.pricing = pricing;
        }

        // Scenario A: Max Revenue
        public void Calculate(int rodLength)
        {
            int totalRevenue = 0;

            int[] lengths = pricing.GetLengths();
            int[] prices = pricing.GetPrices();
            int count = pricing.GetCount();

            Console.Write("Cuts Used: ");

            for (int i = 0; i < count; i++)
            {
                int pieces = rodLength / lengths[i];
                totalRevenue += pieces * prices[i];
                rodLength = rodLength % lengths[i];

                for (int j = 0; j < pieces; j++)
                {
                    Console.Write(lengths[i] + "ft ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total Revenue = " + totalRevenue);
        }

        // Scenario B: Waste constraint
        public void CalculateWithWaste(int rodLength)
        {
            Console.Write("Enter allowed waste: ");
            int waste = int.Parse(Console.ReadLine());

            int usableLength = rodLength - waste;
            Calculate(usableLength);
        }

        // Scenario C: Max Revenue + Minimum Waste
        public void CalculateWithMinWaste(int rodLength)
        {
            int[] lengths = pricing.GetLengths();
            int[] prices = pricing.GetPrices();
            int count = pricing.GetCount();

            int bestRevenue = 0;
            int minWaste = rodLength;

            for (int i = 0; i < count; i++)
            {
                int pieces = rodLength / lengths[i];
                int revenue = pieces * prices[i];
                int waste = rodLength % lengths[i];

                if (revenue > bestRevenue)
                {
                    bestRevenue = revenue;
                    minWaste = waste;
                }
            }

            Console.WriteLine("Best Revenue = " + bestRevenue);
            Console.WriteLine("Minimum Waste = " + minWaste + "ft");
        }
    }
}
