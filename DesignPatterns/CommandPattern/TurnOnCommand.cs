namespace CommandPattern
{
    using CommandPattern.Contracts;

    public class TurnOnCommand : ICommand
    {
        private Light light;

        public TurnOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.TurnOn();
        }
    }
}
