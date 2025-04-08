namespace UndoableCommandPattern
{
    using Contracts;

    public class History
    {
        private Stack<IUndoableCommand> commands;

        public History()
        {
            this.commands = new Stack<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command)
        {
            this.commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            if (this.commands.Count == 0)
            {
                throw new InvalidOperationException("Command history empty!");
            }

            return this.commands.Pop(); 
        }

        public int Size()
        {
            return this.commands.Count;
        }
    }
}
