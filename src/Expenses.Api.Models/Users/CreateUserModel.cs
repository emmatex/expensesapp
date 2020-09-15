using System.ComponentModel.DataAnnotations;

namespace Expenses.Api.Models.Users
{
    public class CreateUserModel : UserManipulationModel
    {
        public CreateUserModel()
        {
            Roles = new string[0];
        }

        [Required]
        public override string FirstName { get; set; }
        [Required]
        public override string LastName { get; set; }
        [Required]
        public override string Username { get; set; }
        [Required]
        public string Password { get; set; }  
        public string[] Roles { get; set; }
    }
}
