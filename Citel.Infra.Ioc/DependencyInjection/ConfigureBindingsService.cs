using Citel.Api.Repository;
using Citel.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Citel.Infra.Ioc.DependencyInjection
{
    public static class ConfigureBindingsService
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
