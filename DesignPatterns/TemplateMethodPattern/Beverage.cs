namespace TemplateMethodPattern
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            this.BoilWater();
            this.PourInCup();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring water into cup.");
        }

        protected abstract void Brew();

        protected virtual void AddCondiments()
        {

        }
    }
}
