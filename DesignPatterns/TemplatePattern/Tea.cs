namespace TemplatePattern
{
    using Contracts;

    public class Tea : IBeverage
    {
        public void Prepare()
        {
            this.Brew();
            this.AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes.");
        }

        private void AddCondiments()
        {
            if (AreCondimentsNeeded())
            {
                Console.WriteLine("Adding lemon to the tea.");
            }
        }

        private bool AreCondimentsNeeded()
        {
            Console.WriteLine("Would you like lemon? (y/n)");
            string input = Console.ReadLine()!;
            return input.ToLower() == "y";
        }
    }
}
