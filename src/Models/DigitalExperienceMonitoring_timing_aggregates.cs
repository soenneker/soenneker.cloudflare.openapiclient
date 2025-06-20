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
    public partial class DigitalExperienceMonitoring_timing_aggregates : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avgMs property</summary>
        public int? AvgMs { get; set; }
        /// <summary>The history property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_aggregate_stat>? History { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_aggregate_stat> History { get; set; }
#endif
        /// <summary>The overTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates_overTime? OverTime { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates_overTime OverTime { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates"/> and sets the default values.
        /// </summary>
        public DigitalExperienceMonitoring_timing_aggregates()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "avgMs", n => { AvgMs = n.GetIntValue(); } },
                { "history", n => { History = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_aggregate_stat>(global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_aggregate_stat.CreateFromDiscriminatorValue)?.AsList(); } },
                { "overTime", n => { OverTime = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates_overTime>(global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates_overTime.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("avgMs", AvgMs);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_aggregate_stat>("history", History);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_timing_aggregates_overTime>("overTime", OverTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
