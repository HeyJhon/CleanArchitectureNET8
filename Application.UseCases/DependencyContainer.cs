using Application.UseCasePorts;
using Application.UseCases.CreateProduct;
using Application.UseCases.GetAllProducts;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(
        this IServiceCollection services)
    {
        services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
        services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

        return services;
    }
}