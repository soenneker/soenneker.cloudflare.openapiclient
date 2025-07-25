// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Load_balancers_patch_load_balancer : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Controls features that modify the routing of requests to pools and origins in response to dynamic conditions, such as during the interval between active health monitoring requests. For example, zero-downtime failover occurs immediately when an origin becomes unavailable due to HTTP 521, 522, or 523 response codes. If there is another healthy origin in the same pool, the request is retried once against this alternate origin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_adaptive_routing? AdaptiveRouting { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_adaptive_routing AdaptiveRouting { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A mapping of country codes to a list of pool IDs (ordered by their failover priority) for the given country. Any country not explicitly defined will fall back to using the corresponding region_pool mapping if it exists else to default_pools.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_country_pools? CountryPools { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_country_pools CountryPools { get; set; }
#endif
        /// <summary>A list of pool IDs ordered by their failover priority. Pools defined here are used by default, or when region_pools are not configured for a given region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefaultPools { get; set; }
#nullable restore
#else
        public List<string> DefaultPools { get; set; }
#endif
        /// <summary>Object description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Whether to enable (the default) this load balancer.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The pool ID to use when all other pools are detected as unhealthy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FallbackPool { get; set; }
#nullable restore
#else
        public string FallbackPool { get; set; }
#endif
        /// <summary>Controls location-based steering for non-proxied requests. See `steering_policy` to learn how steering is affected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_location_strategy? LocationStrategy { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_location_strategy LocationStrategy { get; set; }
#endif
        /// <summary>The DNS hostname to associate with your Load Balancer. If this hostname already exists as a DNS record in Cloudflare&apos;s DNS, the Load Balancer will take precedence and the DNS record will not be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>(Enterprise only): A mapping of Cloudflare PoP identifiers to a list of pool IDs (ordered by their failover priority) for the PoP (datacenter). Any PoPs not explicitly defined will fall back to using the corresponding country_pool, then region_pool mapping if it exists else to default_pools.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_pop_pools? PopPools { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_pop_pools PopPools { get; set; }
#endif
        /// <summary>Whether the hostname should be gray clouded (false) or orange clouded (true).</summary>
        public bool? Proxied { get; set; }
        /// <summary>Configures pool weights.- `steering_policy=&quot;random&quot;`: A random pool is selected with probability proportional to pool weights.- `steering_policy=&quot;least_outstanding_requests&quot;`: Use pool weights to scale each pool&apos;s outstanding requests.- `steering_policy=&quot;least_connections&quot;`: Use pool weights to scale each pool&apos;s open connections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_random_steering? RandomSteering { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_random_steering RandomSteering { get; set; }
#endif
        /// <summary>A mapping of region codes to a list of pool IDs (ordered by their failover priority) for the given region. Any regions not explicitly defined will fall back to using default_pools.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_region_pools? RegionPools { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_region_pools RegionPools { get; set; }
#endif
        /// <summary>BETA Field Not General Access: A list of rules for this load balancer to execute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_rules_item>? Rules { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_rules_item> Rules { get; set; }
#endif
        /// <summary>Specifies the type of session affinity the load balancer should use unless specified as `&quot;none&quot;`. The supported types are:- `&quot;cookie&quot;`: On the first request to a proxied load balancer, a cookie is generated, encoding information of which origin the request will be forwarded to. Subsequent requests, by the same client to the same load balancer, will be sent to the origin server the cookie encodes, for the duration of the cookie and as long as the origin server remains healthy. If the cookie has expired or the origin server is unhealthy, then a new origin server is calculated and used.- `&quot;ip_cookie&quot;`: Behaves the same as `&quot;cookie&quot;` except the initial origin selection is stable and based on the client&apos;s ip address.- `&quot;header&quot;`: On the first request to a proxied load balancer, a session key based on the configured HTTP headers (see `session_affinity_attributes.headers`) is generated, encoding the request headers used for storing in the load balancer session state which origin the request will be forwarded to. Subsequent requests to the load balancer with the same headers will be sent to the same origin server, for the duration of the session and as long as the origin server remains healthy. If the session has been idle for the duration of `session_affinity_ttl` seconds or the origin server is unhealthy, then a new origin server is calculated and used. See `headers` in `session_affinity_attributes` for additional required configuration.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity? SessionAffinity { get; set; }
        /// <summary>Configures attributes for session affinity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity_attributes? SessionAffinityAttributes { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity_attributes SessionAffinityAttributes { get; set; }
#endif
        /// <summary>Time, in seconds, until a client&apos;s session expires after being created. Once the expiry time has been reached, subsequent requests may get sent to a different origin server. The accepted ranges per `session_affinity` policy are:- `&quot;cookie&quot;` / `&quot;ip_cookie&quot;`: The current default of 23 hours will be used unless explicitly set. The accepted range of values is between [1800, 604800].- `&quot;header&quot;`: The current default of 1800 seconds will be used unless explicitly set. The accepted range of values is between [30, 3600]. Note: With session affinity by header, sessions only expire after they haven&apos;t been used for the number of seconds specified.</summary>
        public double? SessionAffinityTtl { get; set; }
        /// <summary>Steering Policy for this load balancer.- `&quot;off&quot;`: Use `default_pools`.- `&quot;geo&quot;`: Use `region_pools`/`country_pools`/`pop_pools`. For non-proxied requests, the country for `country_pools` is determined by `location_strategy`.- `&quot;random&quot;`: Select a pool randomly.- `&quot;dynamic_latency&quot;`: Use round trip time to select the closest pool in default_pools (requires pool health checks).- `&quot;proximity&quot;`: Use the pools&apos; latitude and longitude to select the closest pool using the Cloudflare PoP location for proxied requests or the location determined by `location_strategy` for non-proxied requests.- `&quot;least_outstanding_requests&quot;`: Select a pool by taking into consideration `random_steering` weights, as well as each pool&apos;s number of outstanding requests. Pools with more pending requests are weighted proportionately less relative to others.- `&quot;least_connections&quot;`: Select a pool by taking into consideration `random_steering` weights, as well as each pool&apos;s number of open connections. Pools with more open connections are weighted proportionately less relative to others. Supported for HTTP/1 and HTTP/2 connections.- `&quot;&quot;`: Will map to `&quot;geo&quot;` if you use `region_pools`/`country_pools`/`pop_pools` otherwise `&quot;off&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_steering_policy? SteeringPolicy { get; set; }
        /// <summary>Time to live (TTL) of the DNS entry for the IP address returned by this load balancer. This only applies to gray-clouded (unproxied) load balancers.</summary>
        public double? Ttl { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Load_balancers_patch_load_balancer"/> and sets the default values.
        /// </summary>
        public Load_balancers_patch_load_balancer()
        {
            AdditionalData = new Dictionary<string, object>();
            SessionAffinity = global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Load_balancers_patch_load_balancer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Load_balancers_patch_load_balancer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Load_balancers_patch_load_balancer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "adaptive_routing", n => { AdaptiveRouting = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_adaptive_routing>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_adaptive_routing.CreateFromDiscriminatorValue); } },
                { "country_pools", n => { CountryPools = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_country_pools>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_country_pools.CreateFromDiscriminatorValue); } },
                { "default_pools", n => { DefaultPools = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "fallback_pool", n => { FallbackPool = n.GetStringValue(); } },
                { "location_strategy", n => { LocationStrategy = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_location_strategy>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_location_strategy.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "pop_pools", n => { PopPools = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_pop_pools>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_pop_pools.CreateFromDiscriminatorValue); } },
                { "proxied", n => { Proxied = n.GetBoolValue(); } },
                { "random_steering", n => { RandomSteering = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_random_steering>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_random_steering.CreateFromDiscriminatorValue); } },
                { "region_pools", n => { RegionPools = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_region_pools>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_region_pools.CreateFromDiscriminatorValue); } },
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_rules_item>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_rules_item.CreateFromDiscriminatorValue)?.AsList(); } },
                { "session_affinity", n => { SessionAffinity = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity>(); } },
                { "session_affinity_attributes", n => { SessionAffinityAttributes = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity_attributes>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity_attributes.CreateFromDiscriminatorValue); } },
                { "session_affinity_ttl", n => { SessionAffinityTtl = n.GetDoubleValue(); } },
                { "steering_policy", n => { SteeringPolicy = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_steering_policy>(); } },
                { "ttl", n => { Ttl = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_adaptive_routing>("adaptive_routing", AdaptiveRouting);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_country_pools>("country_pools", CountryPools);
            writer.WriteCollectionOfPrimitiveValues<string>("default_pools", DefaultPools);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("fallback_pool", FallbackPool);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_location_strategy>("location_strategy", LocationStrategy);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_pop_pools>("pop_pools", PopPools);
            writer.WriteBoolValue("proxied", Proxied);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_random_steering>("random_steering", RandomSteering);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_region_pools>("region_pools", RegionPools);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_rules_item>("rules", Rules);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity>("session_affinity", SessionAffinity);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_session_affinity_attributes>("session_affinity_attributes", SessionAffinityAttributes);
            writer.WriteDoubleValue("session_affinity_ttl", SessionAffinityTtl);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_steering_policy>("steering_policy", SteeringPolicy);
            writer.WriteDoubleValue("ttl", Ttl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
