namespace TemplatePattern
{
    using Contracts;

    public class BeverageMaker
    {
        private IBeverage beverage;

        public BeverageMaker(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public void SetBeverage(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public void MakeBeverage()
        {
            this.BoilWater();
            this.PourInCup();
            this.beverage.Prepare();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring water into cup.");
        }
    }
}
