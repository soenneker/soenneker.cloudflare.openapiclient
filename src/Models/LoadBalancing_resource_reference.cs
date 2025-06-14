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
    /// A reference to a load balancer resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LoadBalancing_resource_reference : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of references to (referrer) or from (referral) this resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_references>? References { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_references> References { get; set; }
#endif
        /// <summary>When listed as a reference, the type (direction) of the reference.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_reference_type? ReferenceType { get; set; }
        /// <summary>The resource_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ResourceId { get; set; }
#nullable restore
#else
        public UntypedNode ResourceId { get; set; }
#endif
        /// <summary>The human-identifiable name of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName { get; set; }
#nullable restore
#else
        public string ResourceName { get; set; }
#endif
        /// <summary>The type of the resource.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_resource_type? ResourceType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference"/> and sets the default values.
        /// </summary>
        public LoadBalancing_resource_reference()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "reference_type", n => { ReferenceType = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_reference_type>(); } },
                { "references", n => { References = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_references>(global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_references.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resource_id", n => { ResourceId = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "resource_name", n => { ResourceName = n.GetStringValue(); } },
                { "resource_type", n => { ResourceType = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_resource_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_references>("references", References);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_reference_type>("reference_type", ReferenceType);
            writer.WriteObjectValue<UntypedNode>("resource_id", ResourceId);
            writer.WriteStringValue("resource_name", ResourceName);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.LoadBalancing_resource_reference_resource_type>("resource_type", ResourceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
