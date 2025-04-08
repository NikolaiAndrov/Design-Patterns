namespace UndoableCommandPattern
{
    using UndoableCommandPattern.Contracts;

    public class ItalicCommand : IUndoableCommand
    {
        private HtmlDocument document;
        private History history;
        private string prevContent = string.Empty;

        public ItalicCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            this.prevContent = document.Content;
            this.document.MakeItalic();
            this.history.Push(this);
        }

        public void Unexecute()
        {
            throw new NotImplementedException();
        }
    }
}
