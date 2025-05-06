namespace SimpleFactory
{
    using Enumerations;

    public class CoffeeFactory
    {

        public Coffee CreateCoffee(CoffeeType coffeeType)
        {
            Coffee coffee;

            if (coffeeType == CoffeeType.Espresso)
            {
                coffee = new Coffee(30, 0);
            }
            else if (coffeeType == CoffeeType.Double)
            {
                coffee = new Coffee(60, 0);
            }
            else if (coffeeType == CoffeeType.Macchiato)
            {
                coffee = new Coffee(30, 30);
            }
            else if (coffeeType == CoffeeType.Cappuccino)
            {
                coffee = new Coffee(50, 50);
            }
            else
            {
                throw new ArgumentException();
            }

            return coffee;
        }
    }
}
