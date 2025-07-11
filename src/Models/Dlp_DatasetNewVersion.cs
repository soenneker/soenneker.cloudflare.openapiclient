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
    public partial class Dlp_DatasetNewVersion : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The case_sensitive property</summary>
        public bool? CaseSensitive { get; set; }
        /// <summary>The columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetColumn>? Columns { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetColumn> Columns { get; set; }
#endif
        /// <summary>The encoding_version property</summary>
        public int? EncodingVersion { get; set; }
        /// <summary>The max_cells property</summary>
        public long? MaxCells { get; set; }
        /// <summary>The secret property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Secret { get; set; }
#nullable restore
#else
        public string Secret { get; set; }
#endif
        /// <summary>The version property</summary>
        public long? Version { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetNewVersion"/> and sets the default values.
        /// </summary>
        public Dlp_DatasetNewVersion()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetNewVersion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetNewVersion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetNewVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "case_sensitive", n => { CaseSensitive = n.GetBoolValue(); } },
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetColumn>(global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetColumn.CreateFromDiscriminatorValue)?.AsList(); } },
                { "encoding_version", n => { EncodingVersion = n.GetIntValue(); } },
                { "max_cells", n => { MaxCells = n.GetLongValue(); } },
                { "secret", n => { Secret = n.GetStringValue(); } },
                { "version", n => { Version = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("case_sensitive", CaseSensitive);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetColumn>("columns", Columns);
            writer.WriteIntValue("encoding_version", EncodingVersion);
            writer.WriteLongValue("max_cells", MaxCells);
            writer.WriteStringValue("secret", Secret);
            writer.WriteLongValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
