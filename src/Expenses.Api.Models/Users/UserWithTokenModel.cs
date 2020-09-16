namespace Expenses.Api.Models.Users
{
    public class UserWithTokenModel
    {
        public string Token { get; set; }
        public UserModel User { get; set; }
        public System.DateTime ExpiresAt { get; set; }
    }
}
