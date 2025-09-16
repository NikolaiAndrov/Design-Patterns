namespace MediatorPattern
{
    public class ListBox : UIControl
    {
        private string selection = string.Empty;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string Selection
        {
            get 
            {
                return this.selection; 
            }

            set
            {
                this.selection = value;
                this.owner.Changed(this);
            }
        }
    }
}
