namespace FactoryMethodPattern
{
    using Manufacturers;

    internal class Program
    {
        static void Main(string[] args)
        {
            CreatePhone(new IPhoneManufacturer());
            CreatePhone(new SamsungGalaxyManufacturer());
        }

        private static void CreatePhone(Manufacturer manufacturer)
        {
            var phone = manufacturer.ManufactureGsm();
            phone.Start();
            Console.WriteLine(phone.ToString());
        }
    }
}
