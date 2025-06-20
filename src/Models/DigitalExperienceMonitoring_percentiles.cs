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
    public partial class DigitalExperienceMonitoring_percentiles : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>p50 observed in the time period</summary>
        public double? P50 { get; set; }
        /// <summary>p90 observed in the time period</summary>
        public double? P90 { get; set; }
        /// <summary>p95 observed in the time period</summary>
        public double? P95 { get; set; }
        /// <summary>p99 observed in the time period</summary>
        public double? P99 { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_percentiles"/> and sets the default values.
        /// </summary>
        public DigitalExperienceMonitoring_percentiles()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_percentiles"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_percentiles CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_percentiles();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "p50", n => { P50 = n.GetDoubleValue(); } },
                { "p90", n => { P90 = n.GetDoubleValue(); } },
                { "p95", n => { P95 = n.GetDoubleValue(); } },
                { "p99", n => { P99 = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("p50", P50);
            writer.WriteDoubleValue("p90", P90);
            writer.WriteDoubleValue("p95", P95);
            writer.WriteDoubleValue("p99", P99);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
