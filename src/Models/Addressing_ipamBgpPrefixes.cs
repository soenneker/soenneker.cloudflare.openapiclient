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
    public partial class Addressing_ipamBgpPrefixes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Autonomous System Number (ASN) the prefix will be advertised under.</summary>
        public int? Asn { get; set; }
        /// <summary>Number of times to prepend the Cloudflare ASN to the BGP AS-Path attribute</summary>
        public int? AsnPrependCount { get; set; }
        /// <summary>Determines if Cloudflare advertises a BYOIP BGP prefix even when there is no matching BGP prefix in the Magic routing table. When true, Cloudflare will automatically withdraw the BGP prefix when there are no matching BGP routes, and will resume advertising when there is at least one matching BGP route.</summary>
        public bool? AutoAdvertiseWithdraw { get; set; }
        /// <summary>The bgp_signal_opts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_signal_opts? BgpSignalOpts { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_signal_opts BgpSignalOpts { get; set; }
#endif
        /// <summary>IP Prefix in Classless Inter-Domain Routing format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cidr { get; set; }
#nullable restore
#else
        public string Cidr { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Identifier of BGP Prefix.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The modified_at property</summary>
        public DateTimeOffset? ModifiedAt { get; set; }
        /// <summary>The on_demand property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_on_demand? OnDemand { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_on_demand OnDemand { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_ipamBgpPrefixes"/> and sets the default values.
        /// </summary>
        public Addressing_ipamBgpPrefixes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_ipamBgpPrefixes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_ipamBgpPrefixes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_ipamBgpPrefixes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "asn", n => { Asn = n.GetIntValue(); } },
                { "asn_prepend_count", n => { AsnPrependCount = n.GetIntValue(); } },
                { "auto_advertise_withdraw", n => { AutoAdvertiseWithdraw = n.GetBoolValue(); } },
                { "bgp_signal_opts", n => { BgpSignalOpts = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_signal_opts>(global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_signal_opts.CreateFromDiscriminatorValue); } },
                { "cidr", n => { Cidr = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "modified_at", n => { ModifiedAt = n.GetDateTimeOffsetValue(); } },
                { "on_demand", n => { OnDemand = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_on_demand>(global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_on_demand.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("asn", Asn);
            writer.WriteIntValue("asn_prepend_count", AsnPrependCount);
            writer.WriteBoolValue("auto_advertise_withdraw", AutoAdvertiseWithdraw);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_signal_opts>("bgp_signal_opts", BgpSignalOpts);
            writer.WriteStringValue("cidr", Cidr);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("modified_at", ModifiedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Addressing_bgp_on_demand>("on_demand", OnDemand);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
