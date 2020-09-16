using Expenses.Api.IntegrationTest.Common;
using Expenses.Api.Models.Common;
using Expenses.Api.Models.Expenses;
using FluentAssertions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Expenses.Api.IntegrationTest.Expenses
{
    [Collection("ApiCollection")]
    public class GetListShould
    {
        private readonly ApiServer _server;
        private readonly HttpClient _client;

        public GetListShould(ApiServer server)
        {
            _server = server;
            _client = server.Client;
        }

        public static async Task<DataResult<ExpenseModel>> Get(HttpClient client)
        {
            var response = await client.GetAsync($"api/Expenses");
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<DataResult<ExpenseModel>>(responseText);
            return items;
        }

        [Fact]
        public async Task ReturnAnyList()
        {
            var items = await Get(_client);
            items.Should().NotBeNull();
        }
    }
}
