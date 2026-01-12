namespace CustomFurnitureManufacturing
{
    class RodPricing
    {
        private int[] lengths;
        private int[] prices;
        private int count;

        public RodPricing(int size)
        {
            lengths = new int[size];
            prices = new int[size];
            count = 0;
        }

        public void AddPrice(int length, int price)
        {
            lengths[count] = length;
            prices[count] = price;
            count++;
        }

        public int[] GetLengths()
        {
            return lengths;
        }

        public int[] GetPrices()
        {
            return prices;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
