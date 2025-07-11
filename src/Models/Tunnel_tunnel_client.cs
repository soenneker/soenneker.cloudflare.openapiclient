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
    /// A client (typically cloudflared) that maintains connections to a Cloudflare data center.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Tunnel_tunnel_client : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cloudflared OS architecture used to establish this connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Arch { get; set; }
#nullable restore
#else
        public string Arch { get; set; }
#endif
        /// <summary>The version of the remote tunnel configuration. Used internally to sync cloudflared with the Zero Trust dashboard.</summary>
        public int? ConfigVersion { get; set; }
        /// <summary>The Cloudflare Tunnel connections between your origin and Cloudflare&apos;s edge.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConnection>? Conns { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConnection> Conns { get; set; }
#endif
        /// <summary>Features enabled for the Cloudflare Tunnel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Features { get; set; }
#nullable restore
#else
        public List<string> Features { get; set; }
#endif
        /// <summary>UUID of the Cloudflare Tunnel connection.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Timestamp of when the tunnel connection was started.</summary>
        public DateTimeOffset? RunAt { get; set; }
        /// <summary>The cloudflared version used to establish this connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_tunnel_client"/> and sets the default values.
        /// </summary>
        public Tunnel_tunnel_client()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_tunnel_client"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_tunnel_client CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_tunnel_client();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "arch", n => { Arch = n.GetStringValue(); } },
                { "config_version", n => { ConfigVersion = n.GetIntValue(); } },
                { "conns", n => { Conns = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConnection>(global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConnection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "features", n => { Features = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "run_at", n => { RunAt = n.GetDateTimeOffsetValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("arch", Arch);
            writer.WriteIntValue("config_version", ConfigVersion);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Tunnel_schemasConnection>("conns", Conns);
            writer.WriteCollectionOfPrimitiveValues<string>("features", Features);
            writer.WriteDateTimeOffsetValue("run_at", RunAt);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
