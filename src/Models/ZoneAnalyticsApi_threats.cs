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
    /// Breakdown of totals for threats.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ZoneAnalyticsApi_threats : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total number of identifiable threats received over the time frame.</summary>
        public int? All { get; set; }
        /// <summary>A list of key/value pairs where the key is a two-digit country code and the value is the number of malicious requests received from that country.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_country? Country { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_country Country { get; set; }
#endif
        /// <summary>The list of key/value pairs where the key is a threat category and the value is the number of requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_type? Type { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_type Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats"/> and sets the default values.
        /// </summary>
        public ZoneAnalyticsApi_threats()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats();
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
                { "country", n => { Country = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_country>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_country.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_type>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_type.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_country>("country", Country);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZoneAnalyticsApi_threats_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
