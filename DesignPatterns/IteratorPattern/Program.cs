namespace IteratorPattern
{
    using IteratorPattern.Contracts;

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
        }
    }
}
