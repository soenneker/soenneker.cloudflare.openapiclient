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
    public partial class Healthchecks_query_healthcheck : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hostname or IP address of the origin server to run health checks on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address { get; set; }
#nullable restore
#else
        public string Address { get; set; }
#endif
        /// <summary>A list of regions from which to run health checks. Null means Cloudflare will pick a default region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks?>? CheckRegions { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks?> CheckRegions { get; set; }
#endif
        /// <summary>The number of consecutive fails required from a health check before changing the health to unhealthy.</summary>
        public int? ConsecutiveFails { get; set; }
        /// <summary>The number of consecutive successes required from a health check before changing the health to healthy.</summary>
        public int? ConsecutiveSuccesses { get; set; }
        /// <summary>A human-readable description of the health check.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Parameters specific to an HTTP or HTTPS health check.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_http_config? HttpConfig { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_http_config HttpConfig { get; set; }
#endif
        /// <summary>The interval between each health check. Shorter intervals may give quicker notifications if the origin status changes, but will increase load on the origin as we check from multiple locations.</summary>
        public int? Interval { get; set; }
        /// <summary>A short name to identify the health check. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The number of retries to attempt in case of a timeout before marking the origin as unhealthy. Retries are attempted immediately.</summary>
        public int? Retries { get; set; }
        /// <summary>If suspended, no health checks are sent to the origin.</summary>
        public bool? Suspended { get; set; }
        /// <summary>Parameters specific to TCP health check.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_tcp_config? TcpConfig { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_tcp_config TcpConfig { get; set; }
#endif
        /// <summary>The timeout (in seconds) before marking the health check as failed.</summary>
        public int? Timeout { get; set; }
        /// <summary>The protocol to use for the health check. Currently supported protocols are &apos;HTTP&apos;, &apos;HTTPS&apos; and &apos;TCP&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_query_healthcheck"/> and sets the default values.
        /// </summary>
        public Healthchecks_query_healthcheck()
        {
            AdditionalData = new Dictionary<string, object>();
            Type = "HTTP";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_query_healthcheck"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_query_healthcheck CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_query_healthcheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetStringValue(); } },
                { "check_regions", n => { CheckRegions = n.GetCollectionOfEnumValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks>()?.AsList(); } },
                { "consecutive_fails", n => { ConsecutiveFails = n.GetIntValue(); } },
                { "consecutive_successes", n => { ConsecutiveSuccesses = n.GetIntValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "http_config", n => { HttpConfig = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_http_config>(global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_http_config.CreateFromDiscriminatorValue); } },
                { "interval", n => { Interval = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "retries", n => { Retries = n.GetIntValue(); } },
                { "suspended", n => { Suspended = n.GetBoolValue(); } },
                { "tcp_config", n => { TcpConfig = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_tcp_config>(global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_tcp_config.CreateFromDiscriminatorValue); } },
                { "timeout", n => { Timeout = n.GetIntValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteCollectionOfEnumValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks>("check_regions", CheckRegions);
            writer.WriteIntValue("consecutive_fails", ConsecutiveFails);
            writer.WriteIntValue("consecutive_successes", ConsecutiveSuccesses);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_http_config>("http_config", HttpConfig);
            writer.WriteIntValue("interval", Interval);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("retries", Retries);
            writer.WriteBoolValue("suspended", Suspended);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Healthchecks_tcp_config>("tcp_config", TcpConfig);
            writer.WriteIntValue("timeout", Timeout);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
