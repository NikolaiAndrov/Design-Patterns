namespace FactoryMethodPattern.Products
{
    public class SamsungGalaxy : Gsm
    {
        public SamsungGalaxy()
        {
            this.Name = "Samsung Galaxy";   
        }

        public override void Start()
        {
            Console.WriteLine("Booting up Samsung Galaxy");
            Console.WriteLine("Welcome to your Samsung Galaxy");
        }
    }
}
