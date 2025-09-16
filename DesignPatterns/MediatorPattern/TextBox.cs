namespace MediatorPattern
{
    public class TextBox : UIControl
    {
        private string text = string.Empty;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value;
                this.owner.Changed(this);
            }
        }
    }
}
