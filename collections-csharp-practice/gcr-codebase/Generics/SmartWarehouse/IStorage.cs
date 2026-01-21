namespace SmartWarehouse
{
    public interface IStorage<T>
    {
        void AddItem(T item);
        void ShowItems();
    }
}
