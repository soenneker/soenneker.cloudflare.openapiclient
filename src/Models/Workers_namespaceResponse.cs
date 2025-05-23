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
    public partial class Workers_namespaceResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier? CreatedBy { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier CreatedBy { get; set; }
#endif
        /// <summary>When the script was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_created_on? CreatedOn { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_created_on CreatedOn { get; set; }
#endif
        /// <summary>Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier? ModifiedBy { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier ModifiedBy { get; set; }
#endif
        /// <summary>When the script was last modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_modified_on? ModifiedOn { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_modified_on ModifiedOn { get; set; }
#endif
        /// <summary>API Resource UUID tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_uuid? NamespaceId { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_uuid NamespaceId { get; set; }
#endif
        /// <summary>Name of the Workers for Platforms dispatch namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_dispatch_namespace_name? NamespaceName { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_dispatch_namespace_name NamespaceName { get; set; }
#endif
        /// <summary>The current number of scripts in this Dispatch Namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_script_count? ScriptCount { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_script_count ScriptCount { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_namespaceResponse"/> and sets the default values.
        /// </summary>
        public Workers_namespaceResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_namespaceResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_namespaceResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_namespaceResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_by", n => { CreatedBy = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier.CreateFromDiscriminatorValue); } },
                { "created_on", n => { CreatedOn = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_created_on>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_created_on.CreateFromDiscriminatorValue); } },
                { "modified_by", n => { ModifiedBy = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier.CreateFromDiscriminatorValue); } },
                { "modified_on", n => { ModifiedOn = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_modified_on>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_modified_on.CreateFromDiscriminatorValue); } },
                { "namespace_id", n => { NamespaceId = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_uuid>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_uuid.CreateFromDiscriminatorValue); } },
                { "namespace_name", n => { NamespaceName = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_dispatch_namespace_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_dispatch_namespace_name.CreateFromDiscriminatorValue); } },
                { "script_count", n => { ScriptCount = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_script_count>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_script_count.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier>("created_by", CreatedBy);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_created_on>("created_on", CreatedOn);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_identifier>("modified_by", ModifiedBy);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_modified_on>("modified_on", ModifiedOn);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_uuid>("namespace_id", NamespaceId);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_dispatch_namespace_name>("namespace_name", NamespaceName);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_script_count>("script_count", ScriptCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
