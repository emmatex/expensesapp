using Xunit;

namespace Expenses.Api.IntegrationTest.Common
{
    [CollectionDefinition("ApiCollection")]
    public class DbCollection : ICollectionFixture<ApiServer>
    {
    }
}
