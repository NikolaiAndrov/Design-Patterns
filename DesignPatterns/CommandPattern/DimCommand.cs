namespace CommandPattern
{
    using Contracts;

    class DimCommand : ICommand
    {
        private Light light;

        public DimCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.Dim();
        }
    }
}
