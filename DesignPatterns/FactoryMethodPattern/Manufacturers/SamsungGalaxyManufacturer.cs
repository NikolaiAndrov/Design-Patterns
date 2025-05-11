namespace FactoryMethodPattern.Manufacturers
{
    using FactoryMethodPattern.Products;

    public class SamsungGalaxyManufacturer : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            return new SamsungGalaxy()
            {
                BatteryCapacity = 5000,
                Weight = 200,
                Height = 150,
                Width = 80
            };
        }
    }
}
