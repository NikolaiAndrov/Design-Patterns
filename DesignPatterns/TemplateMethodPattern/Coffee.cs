namespace TemplateMethodPattern
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee for 3 minutes.");
        }

        protected override void AddCondiments()
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
