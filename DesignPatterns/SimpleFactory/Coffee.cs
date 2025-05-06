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
    }
}
