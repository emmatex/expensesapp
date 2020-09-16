namespace Expenses.Api.Common.Exceptions
{
    public class ForbiddenException : System.Exception
    {
        public ForbiddenException(string message) : base(message)
        {

        }
    }
}
