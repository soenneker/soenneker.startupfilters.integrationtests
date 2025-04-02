using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.StartupFilters.IntegrationTests.Tests;

[Collection("Collection")]
public class IntegrationTestsStartupFilterTests : FixturedUnitTest
{

    public IntegrationTestsStartupFilterTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
