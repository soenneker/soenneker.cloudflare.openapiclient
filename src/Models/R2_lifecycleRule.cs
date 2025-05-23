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
    public partial class R2_lifecycleRule : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Transition to abort ongoing multipart uploads.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_abortMultipartUploadsTransition? AbortMultipartUploadsTransition { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_abortMultipartUploadsTransition AbortMultipartUploadsTransition { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Conditions that apply to all transitions of this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_conditions? Conditions { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_conditions Conditions { get; set; }
#endif
        /// <summary>Transition to delete objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_deleteObjectsTransition? DeleteObjectsTransition { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_deleteObjectsTransition DeleteObjectsTransition { get; set; }
#endif
        /// <summary>Whether or not this rule is in effect.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Unique identifier for this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Transitions to change the storage class of objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleStorageTransition>? StorageClassTransitions { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleStorageTransition> StorageClassTransitions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule"/> and sets the default values.
        /// </summary>
        public R2_lifecycleRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "abortMultipartUploadsTransition", n => { AbortMultipartUploadsTransition = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_abortMultipartUploadsTransition>(global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_abortMultipartUploadsTransition.CreateFromDiscriminatorValue); } },
                { "conditions", n => { Conditions = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_conditions>(global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_conditions.CreateFromDiscriminatorValue); } },
                { "deleteObjectsTransition", n => { DeleteObjectsTransition = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_deleteObjectsTransition>(global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_deleteObjectsTransition.CreateFromDiscriminatorValue); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "storageClassTransitions", n => { StorageClassTransitions = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleStorageTransition>(global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleStorageTransition.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_abortMultipartUploadsTransition>("abortMultipartUploadsTransition", AbortMultipartUploadsTransition);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_conditions>("conditions", Conditions);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleRule_deleteObjectsTransition>("deleteObjectsTransition", DeleteObjectsTransition);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lifecycleStorageTransition>("storageClassTransitions", StorageClassTransitions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
