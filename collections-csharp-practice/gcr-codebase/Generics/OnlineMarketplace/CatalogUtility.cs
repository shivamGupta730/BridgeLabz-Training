using System.Collections.Generic;

namespace OnlineMarketplace
{
    public class CatalogUtility<T> : ICatalog<T>
        where T : Product
    {
        private List<T> products = new List<T>();

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void ApplyDiscount(double percentage)
        {
            foreach (T product in products)
            {
                product.Price -= product.Price * percentage / 100;
            }
        }

        public void ShowProducts()
        {
            foreach (T product in products)
            {
                product.Display();
            }
        }
    }
}
