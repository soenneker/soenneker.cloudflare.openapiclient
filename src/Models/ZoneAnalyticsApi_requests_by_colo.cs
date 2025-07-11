// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>
    /// Breakdown of totals for requests.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ZoneAnalyticsApi_requests_by_colo : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total number of requests served.</summary>
        public int? All { get; set; }
        /// <summary>Total number of cached requests served.</summary>
        public int? Cached { get; set; }
        /// <summary>Key/value pairs where the key is a two-digit country code and the value is the number of requests served to that country.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_country? Country { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_country Country { get; set; }
#endif
        /// <summary>A variable list of key/value pairs where the key is a HTTP status code and the value is the number of requests with that code served.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_http_status? HttpStatus { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_http_status HttpStatus { get; set; }
#endif
        /// <summary>Total number of requests served from the origin.</summary>
        public int? Uncached { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo"/> and sets the default values.
        /// </summary>
        public ZoneAnalyticsApi_requests_by_colo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "all", n => { All = n.GetIntValue(); } },
                { "cached", n => { Cached = n.GetIntValue(); } },
                { "country", n => { Country = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_country>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_country.CreateFromDiscriminatorValue); } },
                { "http_status", n => { HttpStatus = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_http_status>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_http_status.CreateFromDiscriminatorValue); } },
                { "uncached", n => { Uncached = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("all", All);
            writer.WriteIntValue("cached", Cached);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_country>("country", Country);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_requests_by_colo_http_status>("http_status", HttpStatus);
            writer.WriteIntValue("uncached", Uncached);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
