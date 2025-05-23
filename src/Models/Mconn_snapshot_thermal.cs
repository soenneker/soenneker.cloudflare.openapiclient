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
    /// Snapshot Thermal
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Mconn_snapshot_thermal : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Connector identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorId { get; set; }
#nullable restore
#else
        public string ConnectorId { get; set; }
#endif
        /// <summary>Critical failure temperature of the component (degrees Celsius)</summary>
        public double? CriticalCelcius { get; set; }
        /// <summary>Current temperature of the component (degrees Celsius)</summary>
        public double? CurrentCelcius { get; set; }
        /// <summary>Sensor identifier for the component</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>Maximum temperature of the component (degrees Celsius)</summary>
        public double? MaxCelcius { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mconn_snapshot_thermal"/> and sets the default values.
        /// </summary>
        public Mconn_snapshot_thermal()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mconn_snapshot_thermal"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Mconn_snapshot_thermal CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Mconn_snapshot_thermal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "connector_id", n => { ConnectorId = n.GetStringValue(); } },
                { "critical_celcius", n => { CriticalCelcius = n.GetDoubleValue(); } },
                { "current_celcius", n => { CurrentCelcius = n.GetDoubleValue(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "max_celcius", n => { MaxCelcius = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("connector_id", ConnectorId);
            writer.WriteDoubleValue("critical_celcius", CriticalCelcius);
            writer.WriteDoubleValue("current_celcius", CurrentCelcius);
            writer.WriteStringValue("label", Label);
            writer.WriteDoubleValue("max_celcius", MaxCelcius);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
