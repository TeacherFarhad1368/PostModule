using Microsoft.Extensions.DependencyInjection;
using PostModule.Application.Services;
using PostModule.Domain.Services;
using PostModule.Infrastracture.EF;
using PostModule.Infrastracture.EF.Repositories;

namespace PostModule.Query
{
    public class Post_Bootstrapper
    {
        public static void Config(IServiceCollection services , string connectionString)
        {
            PostInfrastructure_Bootstrapper.Config(services, connectionString);
            PostApplication_Bootstrapper.Config(services);
        }
    }
}