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
    /// A WARP configuration tied to a single user. Multiple registrations can be created from a single WARP device.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TeamsDevices_registration : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The RFC3339 timestamp when the registration was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The RFC3339 timestamp when the registration was deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeletedAt { get; set; }
#nullable restore
#else
        public string DeletedAt { get; set; }
#endif
        /// <summary>Device details embedded inside of a registration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration_device_details? Device { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration_device_details Device { get; set; }
#endif
        /// <summary>The ID of the registration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The public key used to connect to the Cloudflare network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The type of encryption key used by the WARP client for the active key. Currently &apos;curve25519&apos; for WireGuard and &apos;secp256r1&apos; for MASQUE.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyType { get; set; }
#nullable restore
#else
        public string KeyType { get; set; }
#endif
        /// <summary>The RFC3339 timestamp when the registration was last seen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastSeenAt { get; set; }
#nullable restore
#else
        public string LastSeenAt { get; set; }
#endif
        /// <summary>The RFC3339 timestamp when the registration was revoked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RevokedAt { get; set; }
#nullable restore
#else
        public string RevokedAt { get; set; }
#endif
        /// <summary>Type of the tunnel - wireguard or masque.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TunnelType { get; set; }
#nullable restore
#else
        public string TunnelType { get; set; }
#endif
        /// <summary>The RFC3339 timestamp when the registration was last updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user? User { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration"/> and sets the default values.
        /// </summary>
        public TeamsDevices_registration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "deleted_at", n => { DeletedAt = n.GetStringValue(); } },
                { "device", n => { Device = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration_device_details>(global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration_device_details.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "key_type", n => { KeyType = n.GetStringValue(); } },
                { "last_seen_at", n => { LastSeenAt = n.GetStringValue(); } },
                { "revoked_at", n => { RevokedAt = n.GetStringValue(); } },
                { "tunnel_type", n => { TunnelType = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "user", n => { User = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user>(global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("deleted_at", DeletedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_registration_device_details>("device", Device);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("key_type", KeyType);
            writer.WriteStringValue("last_seen_at", LastSeenAt);
            writer.WriteStringValue("revoked_at", RevokedAt);
            writer.WriteStringValue("tunnel_type", TunnelType);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
