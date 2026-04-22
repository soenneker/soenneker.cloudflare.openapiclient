using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CloudflareOpenApiClientTests : HostedUnitTest
{

    public CloudflareOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
