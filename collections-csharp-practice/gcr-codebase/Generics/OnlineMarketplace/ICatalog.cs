namespace OnlineMarketplace
{
    public interface ICatalog<T>
    {
        void AddProduct(T product);
        void ApplyDiscount(double percentage);
        void ShowProducts();
    }
}
