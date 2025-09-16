namespace MediatorPattern
{
    public class PostsDialogBox : DialogBox
    {
        private Button button;
        private TextBox textBox;
        private ListBox listBox;

        public PostsDialogBox()
        {
            this.button = new Button(this);
            this.textBox = new TextBox(this);
            this.listBox = new ListBox(this);
        }

        public override void Changed(UIControl uIControl)
        {
            if (uIControl == this.listBox)
            {
                this.HandlePostChanged();
            }
            else if (uIControl == this.textBox)
            {
                this.HandleTitleChanged();
            }
        }

        private void HandlePostChanged()
        {
            this.textBox.Text = this.listBox.Selection;
            this.button.IsEnabled = true;
        }

        private void HandleTitleChanged()
        {
            bool isTitleEmpty = this.textBox.Text == "";
            this.button.IsEnabled = !isTitleEmpty;
        }
    }
}
