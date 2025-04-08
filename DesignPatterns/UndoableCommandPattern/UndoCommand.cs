namespace UndoableCommandPattern
{
    using UndoableCommandPattern.Contracts;

    internal class UndoCommand : ICommand
    {
        private History history;

        public UndoCommand(History history) 
        {
            this.history = history;
        }

        public void Execute()
        {
            if (this.history.Size() > 0)
            {
                IUndoableCommand lastCommand = this.history.Pop();
                lastCommand.Unexecute();
            }
        }
    }
}
