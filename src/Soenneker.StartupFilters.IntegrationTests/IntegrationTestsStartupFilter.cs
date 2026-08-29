using Microsoft.AspNetCore.Builder;
using System;
using Soenneker.Middlewares.LocalIpAddress;
using Soenneker.StartupFilters.IntegrationTests.Abstract;

namespace Soenneker.StartupFilters.IntegrationTests;

/// <inheritdoc cref="IIntegrationTestsStartupFilter"/>
public class IntegrationTestsStartupFilter : IIntegrationTestsStartupFilter
{
    /// <summary>
    /// Applies Integration Tests Startup Filter-specific settings to the supplied options.
    /// </summary>
    /// <param name="next">Callback used by configure.</param>
    /// <returns>The resulting action.</returns>
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return app =>
        {
            app.UseMiddleware<LocalIpAddressMiddleware>();
            next(app);
        };
    }
}
