namespace Expenses.Api.Models.Expenses
{
    public class ExpenseModel : ExpenseManipulationModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
