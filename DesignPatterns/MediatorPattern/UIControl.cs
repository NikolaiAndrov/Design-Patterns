namespace MediatorPattern
{
    public abstract class UIControl
    {
        protected DialogBox owner;

        public UIControl(DialogBox owner)
        {
            this.owner = owner;
        }
    }
}
