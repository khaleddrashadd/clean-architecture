using CleanArchitecture.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class DependencyInjection
{
    /// <summary>
    ///     IServicesCollection added via nuget package Microsoft.Extensions.DependencyInjection.Abstractions
    ///     This method is used to register application services with the dependency injection container.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ISubscriptionWriteService, SubscriptionWriteService>();
        return services;
    }
}