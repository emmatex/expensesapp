using Microsoft.AspNetCore.Mvc.Filters;

namespace Expenses.API.Helpers
{
    public interface IActionTransactionHelper
    {
        void BeginTransaction();
        void EndTransaction(ActionExecutedContext filterContext);
        void CloseSession();
    }
}
