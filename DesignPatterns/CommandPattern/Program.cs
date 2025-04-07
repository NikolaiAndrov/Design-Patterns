namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            RemoteControl remoteControl = new RemoteControl(new TurnOnCommand(light));
            remoteControl.PressButton();

            remoteControl.SetCommand(new TurnOffCommand(light));
            remoteControl.PressButton();

            remoteControl.SetCommand(new DimCommand(light));
            remoteControl.PressButton();
        }
    }
}
