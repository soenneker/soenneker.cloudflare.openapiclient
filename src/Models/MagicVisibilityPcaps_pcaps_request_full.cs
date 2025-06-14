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
    public partial class MagicVisibilityPcaps_pcaps_request_full : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The maximum number of bytes to capture. This field only applies to `full` packet captures.</summary>
        public double? ByteLimit { get; set; }
        /// <summary>The name of the data center used for the packet capture. This can be a specific colo (ord02) or a multi-colo name (ORD). This field only applies to `full` packet captures.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColoName { get; set; }
#nullable restore
#else
        public string ColoName { get; set; }
#endif
        /// <summary>The full URI for the bucket. This field only applies to `full` packet captures.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationConf { get; set; }
#nullable restore
#else
        public string DestinationConf { get; set; }
#endif
        /// <summary>The packet capture filter. When this field is empty, all packets are captured.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_filter_v1? FilterV1 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_filter_v1 FilterV1 { get; set; }
#endif
        /// <summary>The limit of packets contained in a packet capture.</summary>
        public double? PacketLimit { get; set; }
        /// <summary>The system used to collect packet captures.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_system? System { get; set; }
        /// <summary>The packet capture duration in seconds.</summary>
        public double? TimeLimit { get; set; }
        /// <summary>The type of packet capture. `Simple` captures sampled packets, and `full` captures entire payloads and non-sampled packets.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_request_full"/> and sets the default values.
        /// </summary>
        public MagicVisibilityPcaps_pcaps_request_full()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_request_full"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_request_full CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_request_full();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "byte_limit", n => { ByteLimit = n.GetDoubleValue(); } },
                { "colo_name", n => { ColoName = n.GetStringValue(); } },
                { "destination_conf", n => { DestinationConf = n.GetStringValue(); } },
                { "filter_v1", n => { FilterV1 = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_filter_v1>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_filter_v1.CreateFromDiscriminatorValue); } },
                { "packet_limit", n => { PacketLimit = n.GetDoubleValue(); } },
                { "system", n => { System = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_system>(); } },
                { "time_limit", n => { TimeLimit = n.GetDoubleValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("byte_limit", ByteLimit);
            writer.WriteStringValue("colo_name", ColoName);
            writer.WriteStringValue("destination_conf", DestinationConf);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_filter_v1>("filter_v1", FilterV1);
            writer.WriteDoubleValue("packet_limit", PacketLimit);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_system>("system", System);
            writer.WriteDoubleValue("time_limit", TimeLimit);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicVisibilityPcaps_pcaps_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
