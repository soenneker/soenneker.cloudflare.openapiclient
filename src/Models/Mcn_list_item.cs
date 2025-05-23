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
    public partial class Mcn_list_item : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The item_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemType { get; set; }
#nullable restore
#else
        public string ItemType { get; set; }
#endif
        /// <summary>The list property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list>? List { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list> List { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item"/> and sets the default values.
        /// </summary>
        public Mcn_list_item()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "item_type", n => { ItemType = n.GetStringValue(); } },
                { "list", n => { List = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list>(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("item_type", ItemType);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list>("list", List);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Mcn_list_item_list : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item? McnResourcePreviewItem { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item McnResourcePreviewItem { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item? McnStringItem { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item McnStringItem { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("item_type")?.GetStringValue();
                var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item.Mcn_list_item_list();
                if("mcn_resource_preview_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnResourcePreviewItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item();
                }
                else if("mcn_string_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnStringItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(McnResourcePreviewItem != null)
                {
                    return McnResourcePreviewItem.GetFieldDeserializers();
                }
                else if(McnStringItem != null)
                {
                    return McnStringItem.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(McnResourcePreviewItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item>(null, McnResourcePreviewItem);
                }
                else if(McnStringItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item>(null, McnStringItem);
                }
            }
        }
    }
}
#pragma warning restore CS0618
