using AutoMapper;
using Expenses.Api.Models.Users;
using Expenses.Queries.Models;

namespace Expenses.API.Maps
{
    public class UserWithTokenMap : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<UserWithToken, UserWithTokenModel>();
        }
    }
}
