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
    public partial class Magic_lan : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>mark true to use this LAN for HA probing. only works for site with HA turned on. only one LAN can be set as the ha_link.</summary>
        public bool? HaLink { get; set; }
        /// <summary>Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The nat property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_nat? Nat { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_nat Nat { get; set; }
#endif
        /// <summary>The physport property</summary>
        public int? Physport { get; set; }
        /// <summary>The routed_subnets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_routed_subnet>? RoutedSubnets { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_routed_subnet> RoutedSubnets { get; set; }
#endif
        /// <summary>Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteId { get; private set; }
#nullable restore
#else
        public string SiteId { get; private set; }
#endif
        /// <summary>If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP). However, if in high availability mode, static_address is required along with secondary and virtual address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan_static_addressing? StaticAddressing { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan_static_addressing StaticAddressing { get; set; }
#endif
        /// <summary>VLAN ID. Use zero for untagged.</summary>
        public int? VlanTag { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan"/> and sets the default values.
        /// </summary>
        public Magic_lan()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ha_link", n => { HaLink = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "nat", n => { Nat = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_nat>(global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_nat.CreateFromDiscriminatorValue); } },
                { "physport", n => { Physport = n.GetIntValue(); } },
                { "routed_subnets", n => { RoutedSubnets = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_routed_subnet>(global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_routed_subnet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "site_id", n => { SiteId = n.GetStringValue(); } },
                { "static_addressing", n => { StaticAddressing = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan_static_addressing>(global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan_static_addressing.CreateFromDiscriminatorValue); } },
                { "vlan_tag", n => { VlanTag = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("ha_link", HaLink);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_nat>("nat", Nat);
            writer.WriteIntValue("physport", Physport);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_routed_subnet>("routed_subnets", RoutedSubnets);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Magic_lan_static_addressing>("static_addressing", StaticAddressing);
            writer.WriteIntValue("vlan_tag", VlanTag);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
