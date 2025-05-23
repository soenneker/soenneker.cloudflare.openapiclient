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
    /// Provides details about the actor who performed the action.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Aaa_auditLogsV2_actor : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The context property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor_context? Context { get; set; }
        /// <summary>The email of the actor who performed the action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The ID of the actor who performed the action. If a user performed the action, this will be their User ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The IP address of the request that performed the action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>Filters by the API token ID when the actor context is an api_token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenId { get; set; }
#nullable restore
#else
        public string TokenId { get; set; }
#endif
        /// <summary>Filters by the API token name when the actor context is an api_token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenName { get; set; }
#nullable restore
#else
        public string TokenName { get; set; }
#endif
        /// <summary>The type of actor.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor"/> and sets the default values.
        /// </summary>
        public Aaa_auditLogsV2_actor()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "context", n => { Context = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor_context>(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "ip_address", n => { IpAddress = n.GetStringValue(); } },
                { "token_id", n => { TokenId = n.GetStringValue(); } },
                { "token_name", n => { TokenName = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor_context>("context", Context);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("ip_address", IpAddress);
            writer.WriteStringValue("token_id", TokenId);
            writer.WriteStringValue("token_name", TokenName);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogsV2_actor_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
