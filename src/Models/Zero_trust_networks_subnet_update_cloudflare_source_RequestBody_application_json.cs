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
    public partial class Zero_trust_networks_subnet_update_cloudflare_source_RequestBody_application_json : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An optional description of the subnet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_comment? Comment { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_comment Comment { get; set; }
#endif
        /// <summary>A user-friendly name for the subnet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_name? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_name Name { get; set; }
#endif
        /// <summary>The private IPv4 or IPv6 range defining the subnet, in CIDR notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_ip_network? Network { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_ip_network Network { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_networks_subnet_update_cloudflare_source_RequestBody_application_json"/> and sets the default values.
        /// </summary>
        public Zero_trust_networks_subnet_update_cloudflare_source_RequestBody_application_json()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_networks_subnet_update_cloudflare_source_RequestBody_application_json"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_networks_subnet_update_cloudflare_source_RequestBody_application_json CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_networks_subnet_update_cloudflare_source_RequestBody_application_json();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comment", n => { Comment = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_comment>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_comment.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_name.CreateFromDiscriminatorValue); } },
                { "network", n => { Network = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_ip_network>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_ip_network.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_comment>("comment", Comment);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_name>("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_subnet_ip_network>("network", Network);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
