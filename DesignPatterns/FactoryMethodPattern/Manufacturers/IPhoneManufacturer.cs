namespace FactoryMethodPattern.Manufacturers
{
    using Products;

    public class IPhoneManufacturer : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            return new IPhone()
            {
                BatteryCapacity = 5000,
                Weight = 200,
                Height = 150,
                Width = 80
            };
        }
    }
}
