using Expenses.Api.IntegrationTest.Common;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Expenses.Api.IntegrationTest.Expenses
{
    [Collection("ApiCollection")]
    public class DeleteShould
    {
        private readonly ApiServer _server;
        private readonly HttpClient _client;

        public DeleteShould(ApiServer server)
        {
            _server = server;
            _client = server.Client;
        }

        [Fact]
        public async Task DeleteExistingItem()
        {
            var item = await new PostShould(_server).CreateNew();

            var response = await _client.DeleteAsync(new Uri($"api/Expenses/{item.Id}", UriKind.Relative));
            response.EnsureSuccessStatusCode();
        }
    }
}
