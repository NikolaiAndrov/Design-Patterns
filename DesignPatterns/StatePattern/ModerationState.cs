namespace StatePattern
{
    using StatePattern.Contracts;
    using StatePattern.Enums;

    public class ModerationState : IState
    {
        private Document document;

        public ModerationState(Document document) 
        {
            this.document = document;
        }

        public void Publish()
        {
            if (this.document.UserRole == UserRoles.Admin)
            {
                this.document.State = new PublishedState(document);
            }
        }
    }
}
