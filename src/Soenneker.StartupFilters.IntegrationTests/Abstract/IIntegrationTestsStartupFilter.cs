using Microsoft.AspNetCore.Hosting;

namespace Soenneker.StartupFilters.IntegrationTests.Abstract;

/// <summary>
/// A StartupFilter injecting middleware crucial to integration testing
/// </summary>
public interface IIntegrationTestsStartupFilter : IStartupFilter
{
}