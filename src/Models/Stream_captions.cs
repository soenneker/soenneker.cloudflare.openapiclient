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
    public partial class Stream_captions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the caption was generated via AI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_generated_caption? Generated { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_generated_caption Generated { get; set; }
#endif
        /// <summary>The language label displayed in the native language to users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_label? Label { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_label Label { get; set; }
#endif
        /// <summary>The language tag in BCP 47 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_language? Language { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_language Language { get; set; }
#endif
        /// <summary>The status of a generated caption.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_caption_status? Status { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_caption_status Status { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_captions"/> and sets the default values.
        /// </summary>
        public Stream_captions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_captions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_captions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_captions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "generated", n => { Generated = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_generated_caption>(global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_generated_caption.CreateFromDiscriminatorValue); } },
                { "label", n => { Label = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_label>(global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_label.CreateFromDiscriminatorValue); } },
                { "language", n => { Language = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_language>(global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_language.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_caption_status>(global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_caption_status.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_generated_caption>("generated", Generated);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_label>("label", Label);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_language>("language", Language);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_caption_status>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
