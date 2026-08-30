[![](https://img.shields.io/nuget/v/soenneker.startupfilters.integrationtests.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.startupfilters.integrationtests/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.startupfilters.integrationtests/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.startupfilters.integrationtests/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.startupfilters.integrationtests.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.startupfilters.integrationtests/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.startupfilters.integrationtests/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.startupfilters.integrationtests/actions/workflows/codeql.yml)

# Soenneker.StartupFilters.IntegrationTests

An ASP.NET Core startup filter that makes in-memory integration-test requests appear to originate from the loopback address.

## Installation

```bash
dotnet add package Soenneker.StartupFilters.IntegrationTests
```

## Usage with `WebApplicationFactory`

```csharp
using Microsoft.AspNetCore.Mvc.Testing;
using Soenneker.StartupFilters.IntegrationTests.Registrars;

await using var factory = new WebApplicationFactory<Program>()
    .WithWebHostBuilder(builder =>
    {
        builder.ConfigureServices(services =>
        {
            services.AddIntegrationTestsStartupFilterAsSingleton();
        });
    });

using HttpClient client = factory.CreateClient();
HttpResponseMessage response = await client.GetAsync("/health");
```

The filter inserts `LocalIpAddressMiddleware` before the application's configured pipeline. For every request, that middleware sets both `HttpContext.Connection.LocalIpAddress` and `RemoteIpAddress` to `IPAddress.Loopback`. This is useful when code under test requires connection-address data that an in-memory test server does not provide.

## Test-only safety

Do not register this package in production. Replacing `RemoteIpAddress` can bypass application behavior that trusts loopback traffic, including IP allowlists or local-only endpoints. Keep the registration inside the integration-test host configuration rather than shared application startup.

The singleton registration is the normal choice because startup filters are consumed while the host builds its middleware pipeline. The scoped registrar is available for specialized hosts, but it is not needed for a standard `WebApplicationFactory` setup.
