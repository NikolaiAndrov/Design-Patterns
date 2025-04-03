using IteratorPattern.Contracts;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingList<string> list = new ShoppingList<string>();
            list.Add("Banana");
            list.Add("Melon");
            list.Add("Sweets");

            IIterator<string> iterator = list.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            list.Remove("Banana");
            list.Add("Water");
            iterator.Reset();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            ShoppingList<string> list2 = new ShoppingList<string>();
            IIterator<string> iterator2 = list2.GetIterator();

            while (iterator2.HasNext())
            {
                Console.WriteLine(iterator2.Current());
                iterator2.Next();
            }
        }
    }
}
