namespace TemplatePattern
{
    using Contracts;

    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            this.Brew();
            this.AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 3 minutes.");
        }

        private void AddCondiments()
        {
            if (AreCondimentsNeeded())
            {
                Console.WriteLine("Adding milk to the coffee.");
            }
        }

        private bool AreCondimentsNeeded()
        {
            Console.WriteLine("Would you like some milk? (y/n)");
            string input = Console.ReadLine()!;
            return input.ToLower() == "y";
        }
    }
}
