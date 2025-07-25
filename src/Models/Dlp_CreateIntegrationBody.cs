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
    public partial class Dlp_CreateIntegrationBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The integration_type property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_RiskScoreIntegrationType? IntegrationType { get; set; }
        /// <summary>A reference id that can be supplied by the client. Currently this should be set to the Access-Okta IDP ID (a UUIDv4).https://developers.cloudflare.com/api/operations/access-identity-providers-get-an-access-identity-provider</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceId { get; set; }
#nullable restore
#else
        public string ReferenceId { get; set; }
#endif
        /// <summary>The base url of the tenant, e.g. &quot;https://tenant.okta.com&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantUrl { get; set; }
#nullable restore
#else
        public string TenantUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_CreateIntegrationBody"/> and sets the default values.
        /// </summary>
        public Dlp_CreateIntegrationBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_CreateIntegrationBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_CreateIntegrationBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_CreateIntegrationBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "integration_type", n => { IntegrationType = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_RiskScoreIntegrationType>(); } },
                { "reference_id", n => { ReferenceId = n.GetStringValue(); } },
                { "tenant_url", n => { TenantUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_RiskScoreIntegrationType>("integration_type", IntegrationType);
            writer.WriteStringValue("reference_id", ReferenceId);
            writer.WriteStringValue("tenant_url", TenantUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
