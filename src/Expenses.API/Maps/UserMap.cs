using AutoMapper;
using Expenses.Api.Models.Users;
using Expenses.Data.Model;
using System.Linq;

namespace Expenses.API.Maps
{
    public class UserMap : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<User, UserModel>();
            map.ForMember(x => x.Roles, x => x.MapFrom(u => u.Roles.Select(r => r.Role.Name).ToArray()));
        }
    }
}
