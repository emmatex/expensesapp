using System.ComponentModel.DataAnnotations;

namespace Expenses.Api.Models.Users
{
    public class UpdateUserModel : UserManipulationModel
    {
        public UpdateUserModel()
        {
            Roles = new string[0];
        }

        [Required]
        public override string FirstName { get; set; }
        [Required]
        public override string LastName { get; set; }
        [Required]
        public override string Username { get; set; }
        public string[] Roles { get; set; }
    }
}
