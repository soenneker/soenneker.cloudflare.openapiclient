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
    /// Cloudflare Tunnel configuration
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Tunnel_configuration : IAdditionalDataHolder, IParsable
    {
        /// <summary>Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_identifier? AccountId { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_identifier AccountId { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The tunnel configuration and ingress rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_config? Config { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_config Config { get; set; }
#endif
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_timestamp? CreatedAt { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_timestamp CreatedAt { get; set; }
#endif
        /// <summary>Indicates if this is a locally or remotely configured tunnel. If `local`, manage the tunnel using a YAML file on the origin machine. If `cloudflare`, manage the tunnel&apos;s configuration on the Zero Trust dashboard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_src? Source { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_src Source { get; set; }
#endif
        /// <summary>UUID of the tunnel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasTunnel_id? TunnelId { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasTunnel_id TunnelId { get; set; }
#endif
        /// <summary>The version of the Tunnel Configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_version? Version { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_version Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_configuration"/> and sets the default values.
        /// </summary>
        public Tunnel_configuration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_configuration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_configuration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_configuration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_id", n => { AccountId = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_identifier>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_identifier.CreateFromDiscriminatorValue); } },
                { "config", n => { Config = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_config>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_config.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_timestamp.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_src>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_src.CreateFromDiscriminatorValue); } },
                { "tunnel_id", n => { TunnelId = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasTunnel_id>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasTunnel_id.CreateFromDiscriminatorValue); } },
                { "version", n => { Version = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_version>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_version.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_identifier>("account_id", AccountId);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_config>("config", Config);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_timestamp>("created_at", CreatedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_src>("source", Source);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasTunnel_id>("tunnel_id", TunnelId);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConfig_version>("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
