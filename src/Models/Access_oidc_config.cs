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
    public partial class Access_oidc_config : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The authorization_endpoint URL of your IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthUrl { get; set; }
#nullable restore
#else
        public string AuthUrl { get; set; }
#endif
        /// <summary>The jwks_uri endpoint of your IdP to allow the IdP keys to sign the tokens</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertsUrl { get; set; }
#nullable restore
#else
        public string CertsUrl { get; set; }
#endif
        /// <summary>Custom claims</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Claims { get; set; }
#nullable restore
#else
        public List<string> Claims { get; set; }
#endif
        /// <summary>Your OAuth Client ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>Your OAuth Client Secret</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSecret { get; set; }
#nullable restore
#else
        public string ClientSecret { get; set; }
#endif
        /// <summary>The claim name for email in the id_token response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailClaimName { get; set; }
#nullable restore
#else
        public string EmailClaimName { get; set; }
#endif
        /// <summary>Enable Proof Key for Code Exchange (PKCE)</summary>
        public bool? PkceEnabled { get; set; }
        /// <summary>OAuth scopes</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Scopes { get; set; }
#nullable restore
#else
        public List<string> Scopes { get; set; }
#endif
        /// <summary>The token_endpoint URL of your IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenUrl { get; set; }
#nullable restore
#else
        public string TokenUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Access_oidc_config"/> and sets the default values.
        /// </summary>
        public Access_oidc_config()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Access_oidc_config"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Access_oidc_config CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Access_oidc_config();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auth_url", n => { AuthUrl = n.GetStringValue(); } },
                { "certs_url", n => { CertsUrl = n.GetStringValue(); } },
                { "claims", n => { Claims = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "client_id", n => { ClientId = n.GetStringValue(); } },
                { "client_secret", n => { ClientSecret = n.GetStringValue(); } },
                { "email_claim_name", n => { EmailClaimName = n.GetStringValue(); } },
                { "pkce_enabled", n => { PkceEnabled = n.GetBoolValue(); } },
                { "scopes", n => { Scopes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "token_url", n => { TokenUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("auth_url", AuthUrl);
            writer.WriteStringValue("certs_url", CertsUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("claims", Claims);
            writer.WriteStringValue("client_id", ClientId);
            writer.WriteStringValue("client_secret", ClientSecret);
            writer.WriteStringValue("email_claim_name", EmailClaimName);
            writer.WriteBoolValue("pkce_enabled", PkceEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("scopes", Scopes);
            writer.WriteStringValue("token_url", TokenUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
