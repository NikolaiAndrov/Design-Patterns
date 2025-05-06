namespace SimpleFactory
{
    using Enumerations;

    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory factory = new CoffeeFactory();
            Coffee coffee = factory.CreateCoffee(CoffeeType.Double);
            Console.WriteLine(coffee.ToString());
        }
    }
}
