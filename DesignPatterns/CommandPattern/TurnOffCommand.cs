namespace CommandPattern
{
    using Contracts;

    public class TurnOffCommand : ICommand
    {
        private Light light;

        public TurnOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.TurnOff();
        }
    }
}
