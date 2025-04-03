namespace IteratorPattern
{
    public class ShoppingList<T>
    {
        private readonly List<T> items;

        public ShoppingList()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }
    }
}
