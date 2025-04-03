namespace IteratorPattern
{
    using IteratorPattern.Contracts;

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

        public IIterator<T> GetIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<T>
        {
            private ShoppingList<T> list;
            private int index;

            public ListIterator(ShoppingList<T> list)
            {
                this.list = list;
                this.index = 0;
            }

            public T Current()
            {
                if (this.index >= 0 && this.index < this.list.items.Count)
                {
                    return this.list.items[this.index];
                }

                throw new IndexOutOfRangeException("Invalid index!");
            }

            public bool HasNext()
            {
                if (this.index < this.list.items.Count - 1)
                {
                    return true;
                }

                return false;
            }

            public void Next()
            {
                this.index++;
            }

            public void Reset()
            {
                this.index = 0;
            }
        }
    }
}
