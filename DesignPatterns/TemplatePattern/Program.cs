namespace TemplatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            BeverageMaker beverage = new BeverageMaker(new Tea());
            beverage.MakeBeverage();

            beverage.SetBeverage(new Coffee());
            beverage.MakeBeverage();

            beverage.SetBeverage(new Camomile());
            beverage.MakeBeverage();
        }
    }
}
