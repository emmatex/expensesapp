namespace Expenses.Api.Models.Users
{
    public class UserModel : UserManipulationModel
    {
        public UserModel()
        {
            Roles = new string[0];
        }

        public int Id { get; set; }
        public string[] Roles { get; set; }
    }
}
