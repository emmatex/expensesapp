namespace Expenses.Api.Models.Expenses
{
    public abstract class ExpenseManipulationModel
    {
        public virtual System.DateTime Date { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual string Comment { get; set; }

    }
}
