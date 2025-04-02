using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Soenneker.StartupFilters.IntegrationTests.Registrars;

/// <summary>
/// A StartupFilter injecting middleware crucial to integration testing
/// </summary>
public static class IntegrationTestRegistrar
{
    /// <summary>
    /// Adds <see cref="IntegrationTestsStartupFilter"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddIntegrationTestAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IStartupFilter, IntegrationTestsStartupFilter>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IntegrationTestsStartupFilter"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddIntegrationTestAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IStartupFilter, IntegrationTestsStartupFilter>();

        return services;
    }
}