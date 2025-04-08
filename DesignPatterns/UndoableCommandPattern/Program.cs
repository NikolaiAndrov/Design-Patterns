namespace UndoableCommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HtmlDocument doc = new HtmlDocument();
            History history = new History();
            doc.Content = "Hello World!";
            Console.WriteLine(doc.Content);

            ItalicCommand italicCommand = new ItalicCommand(doc, history);
            italicCommand.Execute();
            Console.WriteLine(doc.Content);

            UndoCommand undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(doc.Content);
        }
    }
}
