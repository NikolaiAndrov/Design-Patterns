namespace UndoableCommandPattern
{
    public class HtmlDocument
    {
        public HtmlDocument()
        {
        }

        public string Content { get; set; } = string.Empty;

        public void MakeItalic()
        {
            this.Content = $"<i>{this.Content}</i>";
        }
    }
}
