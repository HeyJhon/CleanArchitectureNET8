using Domain.Entities.Interfaces;
using Gateway.RepositoryEFCore.DataContext;
using Gateway.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gateway.RepositoryEFCore;

public static class DependencyContainer
{
    public static IServiceCollection AddRepository(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationEFContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("SqlConnection"))
        );

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}