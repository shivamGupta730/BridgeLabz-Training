using System;

namespace basic.FlashDealz
{
    internal class ProductUtility : IProductSort
    {
        Product[] products;
        int size;

        public ProductUtility(int size)
        {
            this.size = size;
            products = new Product[size];

            for (int i = 0; i < size; i++)
            {
                products[i] = new Product();
            }
        }

        // input discounts
        public void AddDiscount()
        {
            Console.WriteLine("Enter product discounts:");
            for (int i = 0; i < size; i++)
            {
                products[i].Discount = int.Parse(Console.ReadLine());
            }
        }

        // quick sort call
        public void Sort()
        {
            QuickSort(0, size - 1);
        }

        // quick sort logic
        private void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int p = Partition(low, high);
                QuickSort(low, p - 1);
                QuickSort(p + 1, high);
            }
        }

        private int Partition(int low, int high)
        {
            int pivot = products[high].Discount;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // high discount first
                if (products[j].Discount > pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }

            Swap(i + 1, high);
            return i + 1;
        }

        private void Swap(int i, int j)
        {
            int temp = products[i].Discount;
            products[i].Discount = products[j].Discount;
            products[j].Discount = temp;
        }

        // display result
        public void Display()
        {
            Console.WriteLine("Sorted Discounts (High to Low):");
            for (int i = 0; i < size; i++)
            {
                Console.Write(products[i].Discount + " ");
            }
        }
    }
}
