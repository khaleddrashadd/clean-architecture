using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    /// <summary>
    ///     IServicesCollection added via nuget package Microsoft.Extensions.DependencyInjection.Abstractions
    ///     This method is used to register Infrastructure services with the dependency injection container.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}