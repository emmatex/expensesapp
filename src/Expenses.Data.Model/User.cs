using System.Collections.Generic;

namespace Expenses.Data.Model
{
    public class User : BaseEntity
    {  
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual IList<UserRole> Roles { get; set; } = new List<UserRole>();
    }
}
