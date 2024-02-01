using Application.UseCases;
using Gateway.RepositoryEFCore;
using JFMSystems.Presenters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JFMSystems.IoC;

public static class DependecyContainer
{
    public static IServiceCollection AddJFMSystemsDependencies(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddRepository(configuration);
        services.AddUseCasesServices();
        services.AddPresenters();
        return services;
    }
}