using Soenneker.Cloudflare.Clamav.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.Clamav.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareClamavOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ICloudflareClamavOpenApiHttpClient _httpclient;

    public CloudflareClamavOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ICloudflareClamavOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
