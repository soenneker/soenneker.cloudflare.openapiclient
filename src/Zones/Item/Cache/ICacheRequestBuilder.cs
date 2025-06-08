using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Cache
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{identifier-id}\cache
    /// </summary>
    public interface ICacheRequestBuilder
    {
        /// <summary>
        /// Gets the cache settings for a zone
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <returns>A <see cref="Task{T}"/> of type <see cref="CacheSettings"/></returns>
        Task<CacheSettings> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the cache settings for a zone
        /// </summary>
        /// <param name="body">The cache settings to update</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <returns>A <see cref="Task{T}"/> of type <see cref="CacheSettings"/></returns>
        Task<CacheSettings> PutAsync(CacheSettings body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default);
    }
} 