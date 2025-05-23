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
    public partial class SecretsStore_storeObject : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whenthe secret was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_created? Created { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_created Created { get; set; }
#endif
        /// <summary>Store Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_identifier? Id { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_identifier Id { get; set; }
#endif
        /// <summary>When the secret was modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_modified? Modified { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_modified Modified { get; set; }
#endif
        /// <summary>The name of the store</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_name? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_name Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_storeObject"/> and sets the default values.
        /// </summary>
        public SecretsStore_storeObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_storeObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_storeObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_storeObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created", n => { Created = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_created>(global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_created.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_identifier>(global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_identifier.CreateFromDiscriminatorValue); } },
                { "modified", n => { Modified = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_modified>(global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_modified.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_name.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_created>("created", Created);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_identifier>("id", Id);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_modified>("modified", Modified);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.SecretsStore_store_name>("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
