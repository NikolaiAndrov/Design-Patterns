namespace SimpleFactory
{
    public class Coffee
    {
        public Coffee(int water, int milk)
        {
            this.Water = water;
            this.Milk = milk;
        }

        public int Water { get; set; }

        public int Milk { get; set; }

        public override string ToString()
        {
            return $"Content: Water - {this.Water}ml, Milk - {this.Milk}ml";
        }
    }
}
