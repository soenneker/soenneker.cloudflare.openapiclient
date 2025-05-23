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
    public partial class MagicTransit_node_result : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>AS number associated with the node object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_asn? Asn { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_asn Asn { get; set; }
#endif
        /// <summary>IP address of the node.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_ip? Ip { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_ip Ip { get; set; }
#endif
        /// <summary>Field appears if there is an additional annotation printed when the probe returns. Field also appears when running a GRE+ICMP traceroute to denote which traceroute a node comes from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Labels { get; set; }
#nullable restore
#else
        public List<string> Labels { get; set; }
#endif
        /// <summary>Maximum RTT in ms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_max_rtt_ms? MaxRttMs { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_max_rtt_ms MaxRttMs { get; set; }
#endif
        /// <summary>Mean RTT in ms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_mean_rtt_ms? MeanRttMs { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_mean_rtt_ms MeanRttMs { get; set; }
#endif
        /// <summary>Minimum RTT in ms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_min_rtt_ms? MinRttMs { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_min_rtt_ms MinRttMs { get; set; }
#endif
        /// <summary>Host name of the address, this may be the same as the IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_name? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_name Name { get; set; }
#endif
        /// <summary>Number of packets with a response from this node.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_packet_count? PacketCount { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_packet_count PacketCount { get; set; }
#endif
        /// <summary>Standard deviation of the RTTs in ms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_std_dev_rtt_ms? StdDevRttMs { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_std_dev_rtt_ms StdDevRttMs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_node_result"/> and sets the default values.
        /// </summary>
        public MagicTransit_node_result()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_node_result"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_node_result CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_node_result();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "asn", n => { Asn = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_asn>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_asn.CreateFromDiscriminatorValue); } },
                { "ip", n => { Ip = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_ip>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_ip.CreateFromDiscriminatorValue); } },
                { "labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "max_rtt_ms", n => { MaxRttMs = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_max_rtt_ms>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_max_rtt_ms.CreateFromDiscriminatorValue); } },
                { "mean_rtt_ms", n => { MeanRttMs = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_mean_rtt_ms>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_mean_rtt_ms.CreateFromDiscriminatorValue); } },
                { "min_rtt_ms", n => { MinRttMs = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_min_rtt_ms>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_min_rtt_ms.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_name.CreateFromDiscriminatorValue); } },
                { "packet_count", n => { PacketCount = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_packet_count>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_packet_count.CreateFromDiscriminatorValue); } },
                { "std_dev_rtt_ms", n => { StdDevRttMs = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_std_dev_rtt_ms>(global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_std_dev_rtt_ms.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_asn>("asn", Asn);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_ip>("ip", Ip);
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_max_rtt_ms>("max_rtt_ms", MaxRttMs);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_mean_rtt_ms>("mean_rtt_ms", MeanRttMs);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_min_rtt_ms>("min_rtt_ms", MinRttMs);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_name>("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_packet_count>("packet_count", PacketCount);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.MagicTransit_std_dev_rtt_ms>("std_dev_rtt_ms", StdDevRttMs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
