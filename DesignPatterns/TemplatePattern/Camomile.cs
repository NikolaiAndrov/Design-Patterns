namespace TemplatePattern
{
    using Contracts;

    public class Camomile : IBeverage
    {
        public void Prepare()
        {
            this.Brew();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing camomile for 3 minutes.");
        }
    }
}
