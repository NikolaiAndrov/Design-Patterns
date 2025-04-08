namespace UndoableCommandPattern.Contracts
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
