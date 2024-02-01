using Application.UseCasePorts;
using Microsoft.Extensions.DependencyInjection;

namespace JFMSystems.Presenters
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
            return services;
        }
    }
}
