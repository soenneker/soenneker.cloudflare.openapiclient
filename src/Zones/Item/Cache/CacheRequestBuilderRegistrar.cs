using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;

namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Cache
{
    /// <summary>
    /// Registrar for the cache request builder
    /// </summary>
    public static class CacheRequestBuilderRegistrar
    {
        /// <summary>
        /// Registers the cache request builder with the service collection
        /// </summary>
        /// <param name="services">The service collection to register with</param>
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICacheRequestBuilder, CacheRequestBuilder>();
        }
    }
} 