namespace CommandPattern
{
    using CommandPattern.Contracts;

    public class RemoteControl
    {
        private ICommand command;

        public RemoteControl(ICommand command)
        {
            this.command = command;
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            this.command.Execute();
        }
    }
}
