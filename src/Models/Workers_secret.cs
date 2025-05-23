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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_key"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_text"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Workers_secret : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_key"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_key? WorkersBindingKindSecretKey { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_key WorkersBindingKindSecretKey { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_text"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_text? WorkersBindingKindSecretText { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_text WorkersBindingKindSecretText { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_secret"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_secret CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_secret();
            if("secret_key".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WorkersBindingKindSecretKey = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_key();
            }
            else if("secret_text".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WorkersBindingKindSecretText = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_text();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(WorkersBindingKindSecretKey != null)
            {
                return WorkersBindingKindSecretKey.GetFieldDeserializers();
            }
            else if(WorkersBindingKindSecretText != null)
            {
                return WorkersBindingKindSecretText.GetFieldDeserializers();
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
            if(WorkersBindingKindSecretKey != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_key>(null, WorkersBindingKindSecretKey);
            }
            else if(WorkersBindingKindSecretText != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_secret_text>(null, WorkersBindingKindSecretText);
            }
        }
    }
}
#pragma warning restore CS0618
