using Microsoft.AspNetCore.Builder;
using System;
using Soenneker.Middlewares.LocalIpAddress;
using Soenneker.StartupFilters.IntegrationTests.Abstract;

namespace Soenneker.StartupFilters.IntegrationTests;

/// <inheritdoc cref="IIntegrationTestsStartupFilter"/>
public class IntegrationTestsStartupFilter : IIntegrationTestsStartupFilter
{
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return app =>
        {
            app.UseMiddleware<LocalIpAddressMiddleware>();
            next(app);
        };
    }
}