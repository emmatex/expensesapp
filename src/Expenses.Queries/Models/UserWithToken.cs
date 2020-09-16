using Expenses.Data.Model;

namespace Expenses.Queries.Models
{
    public class UserWithToken
    {
        public string Token { get; set; }
        public User User { get; set; }
        public System.DateTime ExpiresAt { get; set; }
    }
}
