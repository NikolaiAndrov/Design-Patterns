namespace StatePattern
{
    using StatePattern.Contracts;

    public class PublishedState : IState
    {
        private Document document;

        public PublishedState(Document document) 
        {
            this.document = document;
        }

        public void Publish()
        {
            return;
        }
    }
}
