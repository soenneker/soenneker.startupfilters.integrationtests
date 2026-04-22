using Soenneker.Tests.HostedUnit;

namespace Soenneker.StartupFilters.IntegrationTests.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IntegrationTestsStartupFilterTests : HostedUnitTest
{

    public IntegrationTestsStartupFilterTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
