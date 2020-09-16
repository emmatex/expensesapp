using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Expenses.API.Filters;
using Expenses.API.Helpers;
using Expenses.API.Maps;
using Expenses.API.Security;
using Expenses.Data.Access.DAL;
using Expenses.Queries.Queries;
using Expenses.Security;
using Expenses.Security.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Expenses.API.IoC
{
    public static class ContainerSetup
    {
        public static void Setup(IServiceCollection services, IConfigurationRoot configuration)
        {
            AddUow(services, configuration);
            AddQueries(services);
            ConfigureAutoMapper(services);
            ConfigureAuth(services);
        }

        private static void ConfigureAuth(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ITokenBuilder, TokenBuilder>();
            services.AddScoped<ISecurityContext, SecurityContext>();
        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            var mapperConfig = AutoMapperConfigurator.Configure();
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(x => mapper);
            services.AddTransient<IAutoMapper, AutoMapperAdapter>();
        }

        private static void AddUow(IServiceCollection services, IConfigurationRoot configuration)
        {
            var connectionString = configuration["Data:main"];

            services.AddEntityFrameworkSqlite();

            services.AddDbContext<MainDbContext>(options =>
                options.UseSqlite(connectionString));

            services.AddScoped<IUnitOfWork>(ctx => new EFUnitOfWork(ctx.GetRequiredService<MainDbContext>()));

            services.AddScoped<IActionTransactionHelper, ActionTransactionHelper>();
            services.AddScoped<UnitOfWorkFilterAttribute>();
        }

        private static void AddQueries(IServiceCollection services)
        {
            var exampleProcessorType = typeof(UsersQueryProcessor);
            var types = (from t in exampleProcessorType.GetTypeInfo().Assembly.GetTypes()
                         where t.Namespace == exampleProcessorType.Namespace
                               && t.GetTypeInfo().IsClass
                               && t.GetTypeInfo().GetCustomAttribute<CompilerGeneratedAttribute>() == null
                         select t).ToArray();

            foreach (var type in types)
            {
                var interfaceQ = type.GetTypeInfo().GetInterfaces().First();
                services.AddScoped(interfaceQ, type);
            }
        }
    }
}
