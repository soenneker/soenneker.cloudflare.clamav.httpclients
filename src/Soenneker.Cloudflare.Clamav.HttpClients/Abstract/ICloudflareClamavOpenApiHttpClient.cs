using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Cloudflare.Clamav.HttpClients.Abstract;

/// <summary>
/// Provides a shared HTTP client configured with the scanner base URL and bearer API key.
/// </summary>
public interface ICloudflareClamavOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
