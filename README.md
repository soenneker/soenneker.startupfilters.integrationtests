[![](https://img.shields.io/nuget/v/soenneker.startupfilters.integrationtests.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.startupfilters.integrationtests/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.startupfilters.integrationtests/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.startupfilters.integrationtests/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.startupfilters.integrationtests.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.startupfilters.integrationtests/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.startupfilters.integrationtests/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.startupfilters.integrationtests/actions/workflows/codeql.yml)

# Soenneker.StartupFilters.IntegrationTests

A StartupFilter injecting middleware crucial to integration testing.

## Install

```bash
dotnet add package Soenneker.StartupFilters.IntegrationTests
```

## Quick start

```csharp
using Soenneker.StartupFilters.IntegrationTests.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddIntegrationTestsStartupFilterAsSingleton();
```

Adds `IntegrationTestsStartupFilter` as a singleton service.

## What you get

- `IIntegrationTestsStartupFilter` — A StartupFilter injecting middleware crucial to integration testing.
- `IntegrationTestRegistrar` — A StartupFilter injecting middleware crucial to integration testing.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IntegrationTestRegistrar.AddIntegrationTestsStartupFilterAsSingleton(services)` | Adds `IntegrationTestsStartupFilter` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `IntegrationTestRegistrar.AddIntegrationTestsStartupFilterAsScoped(services)` | Adds `IntegrationTestsStartupFilter` as a scoped service. | The same service collection, so additional registrations can be chained. |
