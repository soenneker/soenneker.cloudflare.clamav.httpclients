using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Cloudflare.Clamav.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Cloudflare.Clamav.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class CloudflareClamavOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="CloudflareClamavOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddCloudflareClamavOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ICloudflareClamavOpenApiHttpClient, CloudflareClamavOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="CloudflareClamavOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddCloudflareClamavOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ICloudflareClamavOpenApiHttpClient, CloudflareClamavOpenApiHttpClient>();

        return services;
    }
}
