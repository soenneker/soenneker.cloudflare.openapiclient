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
    public partial class ZeroTrustGateway_locations : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True if the location is the default location.</summary>
        public bool? ClientDefault { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The identifier of the pair of IPv4 addresses assigned to this location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DnsDestinationIpsId { get; set; }
#nullable restore
#else
        public string DnsDestinationIpsId { get; set; }
#endif
        /// <summary>The uuid identifier of the IPv6 block brought to the gateway, so that this location&apos;s IPv6 address is allocated from the Bring Your Own Ipv6(BYOIPv6) block and not from the standard Cloudflare IPv6 block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DnsDestinationIpv6BlockId { get; set; }
#nullable restore
#else
        public string DnsDestinationIpv6BlockId { get; set; }
#endif
        /// <summary>The DNS over HTTPS domain to send DNS requests to. This field is auto-generated by Gateway.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DohSubdomain { get; private set; }
#nullable restore
#else
        public string DohSubdomain { get; private set; }
#endif
        /// <summary>True if the location needs to resolve EDNS queries.</summary>
        public bool? EcsSupport { get; set; }
        /// <summary>The destination endpoints configured for this location. When updating a location, if this field is absent or set with null, the endpoints configuration remains unchanged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_endpoints? Endpoints { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_endpoints Endpoints { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>IPV6 destination ip assigned to this location. DNS requests sent to this IP will counted as the request under this location. This field is auto-generated by Gateway.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ip { get; private set; }
#nullable restore
#else
        public string Ip { get; private set; }
#endif
        /// <summary>The primary destination IPv4 address from the pair identified by the dns_destination_ips_id. This field is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ipv4Destination { get; private set; }
#nullable restore
#else
        public string Ipv4Destination { get; private set; }
#endif
        /// <summary>The backup destination IPv4 address from the pair identified by the dns_destination_ips_id. This field is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ipv4DestinationBackup { get; private set; }
#nullable restore
#else
        public string Ipv4DestinationBackup { get; private set; }
#endif
        /// <summary>The name of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>A list of network ranges that requests from this location would originate from. A non-empty list is only effective if the ipv4 endpoint is enabled for this location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ipv4_network>? Networks { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ipv4_network> Networks { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_locations"/> and sets the default values.
        /// </summary>
        public ZeroTrustGateway_locations()
        {
            AdditionalData = new Dictionary<string, object>();
            DnsDestinationIpsId = "0e4a32c6-6fb8-4858-9296-98f51631e8e6";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_locations"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_locations CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_locations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "client_default", n => { ClientDefault = n.GetBoolValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "dns_destination_ips_id", n => { DnsDestinationIpsId = n.GetStringValue(); } },
                { "dns_destination_ipv6_block_id", n => { DnsDestinationIpv6BlockId = n.GetStringValue(); } },
                { "doh_subdomain", n => { DohSubdomain = n.GetStringValue(); } },
                { "ecs_support", n => { EcsSupport = n.GetBoolValue(); } },
                { "endpoints", n => { Endpoints = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_endpoints>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_endpoints.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "ip", n => { Ip = n.GetStringValue(); } },
                { "ipv4_destination", n => { Ipv4Destination = n.GetStringValue(); } },
                { "ipv4_destination_backup", n => { Ipv4DestinationBackup = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "networks", n => { Networks = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ipv4_network>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ipv4_network.CreateFromDiscriminatorValue)?.AsList(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("client_default", ClientDefault);
            writer.WriteStringValue("dns_destination_ips_id", DnsDestinationIpsId);
            writer.WriteStringValue("dns_destination_ipv6_block_id", DnsDestinationIpv6BlockId);
            writer.WriteBoolValue("ecs_support", EcsSupport);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_endpoints>("endpoints", Endpoints);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ipv4_network>("networks", Networks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
