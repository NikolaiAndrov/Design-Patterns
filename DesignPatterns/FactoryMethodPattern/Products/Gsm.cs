using System.Text;

namespace FactoryMethodPattern.Products
{
    public abstract class Gsm
    {
        public string Name { get; set; } = string.Empty;

        public int BatteryCapacity { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"BatteryCapacity: {this.BatteryCapacity}");
            sb.AppendLine($"Weight: {this.Weight}");
            sb.AppendLine($"Height: {this.Height}");
            sb.AppendLine($"Width: {this.Width}");

            return sb.ToString().TrimEnd();
        }
    }
}
