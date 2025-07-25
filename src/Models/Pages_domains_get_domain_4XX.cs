// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Pages_domains_get_domain_4XX : ApiException, IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item>? Errors { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item> Errors { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => base.Message; }
        /// <summary>The messages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item>? Messages { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item> Messages { get; set; }
#endif
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX_result? Result { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX_result Result { get; set; }
#endif
        /// <summary>Whether the API call was successful</summary>
        public bool? Success { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX"/> and sets the default values.
        /// </summary>
        public Pages_domains_get_domain_4XX()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item>(global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item>(global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item.CreateFromDiscriminatorValue)?.AsList(); } },
                { "result", n => { Result = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX_result>(global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX_result.CreateFromDiscriminatorValue); } },
                { "success", n => { Success = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item>("errors", Errors);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_messages_item>("messages", Messages);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Pages_domains_get_domain_4XX_result>("result", Result);
            writer.WriteBoolValue("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
