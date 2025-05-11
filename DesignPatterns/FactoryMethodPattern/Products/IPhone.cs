namespace FactoryMethodPattern.Products
{
    public class IPhone : Gsm
    {
        public IPhone()
        {
            this.Name = "IPhone";
        }

        public override void Start()
        {
            Console.WriteLine("Booting up IPhone");
            Console.WriteLine("Welcome to your IPhone");
        }
    }
}
