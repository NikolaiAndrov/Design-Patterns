namespace MediatorPattern
{
    public class Button : UIControl
    {
        private bool isEnabled = false;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }

            set
            {
                this.isEnabled = value;
                this.owner.Changed(this);
            }
        }
    }
}
