namespace Expenses.Data.Access.DAL
{
    public interface ITransaction : System.IDisposable
    {
        void Commit();
        void Rollback();
    }
}
