namespace Expenses.Data.Model
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; } = System.DateTime.UtcNow;
    }
}
