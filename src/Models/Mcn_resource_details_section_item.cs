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
    public partial class Mcn_resource_details_section_item : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The helpText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpText { get; set; }
#nullable restore
#else
        public string HelpText { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value? Value { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item"/> and sets the default values.
        /// </summary>
        public Mcn_resource_details_section_item()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "helpText", n => { HelpText = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "value", n => { Value = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value>(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_diff_item"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_item"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Mcn_resource_details_section_item_value : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item? McnListItem { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item McnListItem { get; set; }
#endif
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
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_diff_item"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_diff_item? McnYamlDiffItem { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_diff_item McnYamlDiffItem { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_item"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_item? McnYamlItem { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_item McnYamlItem { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("item_type")?.GetStringValue();
                var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_details_section_item.Mcn_resource_details_section_item_value();
                if("mcn_list_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnListItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item();
                }
                else if("mcn_resource_preview_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnResourcePreviewItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item();
                }
                else if("mcn_string_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnStringItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item();
                }
                else if("mcn_yaml_diff_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnYamlDiffItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_diff_item();
                }
                else if("mcn_yaml_item".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.McnYamlItem = new global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_item();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(McnListItem != null)
                {
                    return McnListItem.GetFieldDeserializers();
                }
                else if(McnResourcePreviewItem != null)
                {
                    return McnResourcePreviewItem.GetFieldDeserializers();
                }
                else if(McnStringItem != null)
                {
                    return McnStringItem.GetFieldDeserializers();
                }
                else if(McnYamlDiffItem != null)
                {
                    return McnYamlDiffItem.GetFieldDeserializers();
                }
                else if(McnYamlItem != null)
                {
                    return McnYamlItem.GetFieldDeserializers();
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
                if(McnListItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_item>(null, McnListItem);
                }
                else if(McnResourcePreviewItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resource_preview_item>(null, McnResourcePreviewItem);
                }
                else if(McnStringItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_string_item>(null, McnStringItem);
                }
                else if(McnYamlDiffItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_diff_item>(null, McnYamlDiffItem);
                }
                else if(McnYamlItem != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_yaml_item>(null, McnYamlItem);
                }
            }
        }
    }
}
#pragma warning restore CS0618
