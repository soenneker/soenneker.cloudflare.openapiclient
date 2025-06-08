using System.Text.Json.Serialization;

namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Cache
{
    /// <summary>
    /// Represents the cache settings for a zone
    /// </summary>
    public class CacheSettings
    {
        /// <summary>
        /// The browser cache TTL in seconds
        /// </summary>
        [JsonPropertyName("browser_cache_ttl")]
        public int BrowserCacheTtl { get; set; }

        /// <summary>
        /// Whether to respect the origin's cache control headers
        /// </summary>
        [JsonPropertyName("respect_strong_etags")]
        public bool RespectStrongEtags { get; set; }

        /// <summary>
        /// Whether to enable the cache
        /// </summary>
        [JsonPropertyName("cache_level")]
        public string CacheLevel { get; set; }

        /// <summary>
        /// Whether to enable the cache
        /// </summary>
        [JsonPropertyName("always_online")]
        public string AlwaysOnline { get; set; }

        /// <summary>
        /// The development mode status
        /// </summary>
        [JsonPropertyName("development_mode")]
        public int DevelopmentMode { get; set; }

        /// <summary>
        /// Whether to enable query string sort
        /// </summary>
        [JsonPropertyName("query_string_sort")]
        public bool QueryStringSort { get; set; }

        /// <summary>
        /// The purge cache on change setting
        /// </summary>
        [JsonPropertyName("purge_cache_on_change")]
        public bool PurgeCacheOnChange { get; set; }
    }
} 