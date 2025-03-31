namespace StatePattern
{
    using StatePattern.Contracts;

    public class ModerationState : IState
    {
        private Document document;

        public ModerationState(Document document) 
        {
            this.document = document;
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }
    }
}
