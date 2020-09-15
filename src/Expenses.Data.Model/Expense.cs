namespace Expenses.Data.Model
{
    public class Expense : BaseEntity
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
