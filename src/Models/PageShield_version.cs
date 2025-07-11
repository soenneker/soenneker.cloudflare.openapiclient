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
    /// The version of the analyzed script.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PageShield_version : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cryptomining score of the JavaScript content.</summary>
        public int? CryptominingScore { get; set; }
        /// <summary>The dataflow score of the JavaScript content.</summary>
        public int? DataflowScore { get; set; }
        /// <summary>The timestamp of when the script was last fetched.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FetchedAt { get; set; }
#nullable restore
#else
        public string FetchedAt { get; set; }
#endif
        /// <summary>The computed hash of the analyzed script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hash { get; set; }
#nullable restore
#else
        public string Hash { get; set; }
#endif
        /// <summary>The integrity score of the JavaScript content.</summary>
        public int? JsIntegrityScore { get; set; }
        /// <summary>The magecart score of the JavaScript content.</summary>
        public int? MagecartScore { get; set; }
        /// <summary>The malware score of the JavaScript content.</summary>
        public int? MalwareScore { get; set; }
        /// <summary>The obfuscation score of the JavaScript content.</summary>
        public int? ObfuscationScore { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_version"/> and sets the default values.
        /// </summary>
        public PageShield_version()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_version"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_version CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_version();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cryptomining_score", n => { CryptominingScore = n.GetIntValue(); } },
                { "dataflow_score", n => { DataflowScore = n.GetIntValue(); } },
                { "fetched_at", n => { FetchedAt = n.GetStringValue(); } },
                { "hash", n => { Hash = n.GetStringValue(); } },
                { "js_integrity_score", n => { JsIntegrityScore = n.GetIntValue(); } },
                { "magecart_score", n => { MagecartScore = n.GetIntValue(); } },
                { "malware_score", n => { MalwareScore = n.GetIntValue(); } },
                { "obfuscation_score", n => { ObfuscationScore = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("cryptomining_score", CryptominingScore);
            writer.WriteIntValue("dataflow_score", DataflowScore);
            writer.WriteStringValue("fetched_at", FetchedAt);
            writer.WriteStringValue("hash", Hash);
            writer.WriteIntValue("js_integrity_score", JsIntegrityScore);
            writer.WriteIntValue("magecart_score", MagecartScore);
            writer.WriteIntValue("malware_score", MalwareScore);
            writer.WriteIntValue("obfuscation_score", ObfuscationScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
