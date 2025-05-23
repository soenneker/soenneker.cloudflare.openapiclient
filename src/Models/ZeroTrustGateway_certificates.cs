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
    public partial class ZeroTrustGateway_certificates : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deployment status of the certificate on Cloudflare&apos;s edge. Certificates in the &apos;available&apos; (previously called &apos;active&apos;) state may be used for Gateway TLS interception.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_binding_status? BindingStatus { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_binding_status BindingStatus { get; set; }
#endif
        /// <summary>The CA certificate</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate { get; private set; }
#nullable restore
#else
        public string Certificate { get; private set; }
#endif
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp? CreatedAt { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp CreatedAt { get; set; }
#endif
        /// <summary>The expires_on property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp? ExpiresOn { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp ExpiresOn { get; set; }
#endif
        /// <summary>The SHA256 fingerprint of the certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint { get; private set; }
#nullable restore
#else
        public string Fingerprint { get; private set; }
#endif
        /// <summary>Certificate UUID tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_uuid? Id { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_uuid Id { get; set; }
#endif
        /// <summary>Use this certificate for Gateway TLS interception</summary>
        public bool? InUse { get; private set; }
        /// <summary>The organization that issued the certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerOrg { get; private set; }
#nullable restore
#else
        public string IssuerOrg { get; private set; }
#endif
        /// <summary>The entire issuer field of the certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerRaw { get; private set; }
#nullable restore
#else
        public string IssuerRaw { get; private set; }
#endif
        /// <summary>The type of certificate, either BYO-PKI (custom) or Gateway-managed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_type? Type { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_type Type { get; set; }
#endif
        /// <summary>The updated_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp? UpdatedAt { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp UpdatedAt { get; set; }
#endif
        /// <summary>The uploaded_on property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp? UploadedOn { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp UploadedOn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_certificates"/> and sets the default values.
        /// </summary>
        public ZeroTrustGateway_certificates()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_certificates"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_certificates CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_certificates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "binding_status", n => { BindingStatus = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_binding_status>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_binding_status.CreateFromDiscriminatorValue); } },
                { "certificate", n => { Certificate = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp.CreateFromDiscriminatorValue); } },
                { "expires_on", n => { ExpiresOn = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp.CreateFromDiscriminatorValue); } },
                { "fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                { "id", n => { Id = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_uuid>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_uuid.CreateFromDiscriminatorValue); } },
                { "in_use", n => { InUse = n.GetBoolValue(); } },
                { "issuer_org", n => { IssuerOrg = n.GetStringValue(); } },
                { "issuer_raw", n => { IssuerRaw = n.GetStringValue(); } },
                { "type", n => { Type = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_type>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_type.CreateFromDiscriminatorValue); } },
                { "updated_at", n => { UpdatedAt = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp.CreateFromDiscriminatorValue); } },
                { "uploaded_on", n => { UploadedOn = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_binding_status>("binding_status", BindingStatus);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>("created_at", CreatedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>("expires_on", ExpiresOn);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_uuid>("id", Id);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_type>("type", Type);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>("updated_at", UpdatedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>("uploaded_on", UploadedOn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
