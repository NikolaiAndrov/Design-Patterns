namespace StatePattern
{
    using StatePattern.Contracts;
    using StatePattern.Enums;

    public class Document
    {
        public Document(UserRoles userRole) 
        { 
            this.State = new DraftState(this);
            this.UserRole = userRole;
        }

        public IState State { get; set; }
        public UserRoles UserRole { get; set; }

        public void Publish()
        {
            this.State.Publish();
        }
    }
}
