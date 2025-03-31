namespace StatePattern
{
    using StatePattern.Contracts;

    public class DraftState : IState
    {
        private Document document;

        public DraftState(Document document)
        {
            this.document = document;
        }

        public void Publish()
        {
            this.document.State = new ModerationState(this.document);
        }
    }
}
