using Microsoft.AspNetCore.Hosting;

namespace Soenneker.StartupFilters.IntegrationTests.Abstract;

/// <summary>
/// Adds middleware that makes integration-test requests appear to originate from the loopback address.
/// </summary>
public interface IIntegrationTestsStartupFilter : IStartupFilter
{
}
