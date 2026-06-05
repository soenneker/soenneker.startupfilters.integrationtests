using Microsoft.AspNetCore.Builder;
using System;
using Soenneker.Middlewares.LocalIpAddress;
using Soenneker.StartupFilters.IntegrationTests.Abstract;

namespace Soenneker.StartupFilters.IntegrationTests;

/// <inheritdoc cref="IIntegrationTestsStartupFilter"/>
public class IntegrationTestsStartupFilter : IIntegrationTestsStartupFilter
{
    /// <summary>
    /// Configures the specified options.
    /// </summary>
    /// <param name="next">The next.</param>
    /// <returns>The result of the operation.</returns>
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return app =>
        {
            app.UseMiddleware<LocalIpAddressMiddleware>();
            next(app);
        };
    }
}