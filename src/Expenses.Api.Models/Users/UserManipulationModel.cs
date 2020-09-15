namespace Expenses.Api.Models.Users
{
    public abstract class UserManipulationModel
    {
        public virtual string Username { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
