using Citel.Api.Repository;
using Citel.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Citel.Infra.Ioc.DependencyInjection
{
    public static class ConfigureBindingsRepository
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
