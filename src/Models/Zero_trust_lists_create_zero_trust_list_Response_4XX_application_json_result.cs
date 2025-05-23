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
    public partial class Zero_trust_lists_create_zero_trust_list_Response_4XX_application_json_result : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp? CreatedAt { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp CreatedAt { get; set; }
#endif
        /// <summary>The description of the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_description? Description { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_description Description { get; set; }
#endif
        /// <summary>API Resource UUID tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasUuid? Id { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasUuid Id { get; set; }
#endif
        /// <summary>The items in the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Gateway>? Items { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Gateway> Items { get; set; }
#endif
        /// <summary>The name of the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_name? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_name Name { get; set; }
#endif
        /// <summary>The type of list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasType? Type { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasType Type { get; set; }
#endif
        /// <summary>The updated_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp? UpdatedAt { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp UpdatedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_lists_create_zero_trust_list_Response_4XX_application_json_result"/> and sets the default values.
        /// </summary>
        public Zero_trust_lists_create_zero_trust_list_Response_4XX_application_json_result()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_lists_create_zero_trust_list_Response_4XX_application_json_result"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_lists_create_zero_trust_list_Response_4XX_application_json_result CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_lists_create_zero_trust_list_Response_4XX_application_json_result();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_description>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_description.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasUuid>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasUuid.CreateFromDiscriminatorValue); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Gateway>(global::Soenneker.Cloudflare.OpenApiClient.Models.Gateway.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_name.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasType>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasType.CreateFromDiscriminatorValue); } },
                { "updated_at", n => { UpdatedAt = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>("created_at", CreatedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_description>("description", Description);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasUuid>("id", Id);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Gateway>("items", Items);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_name>("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasType>("type", Type);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_read_only_timestamp>("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
