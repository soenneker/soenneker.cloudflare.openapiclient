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
    public partial class Dlp_Dataset : IAdditionalDataHolder, IParsable
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
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The description of the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The encoding_version property</summary>
        public int? EncodingVersion { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The num_cells property</summary>
        public long? NumCells { get; set; }
        /// <summary>The secret property</summary>
        public bool? Secret { get; set; }
        /// <summary>The status property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUploadStatus? Status { get; set; }
        /// <summary>When the dataset was last updated.This includes name or description changes as well as uploads.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The uploads property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUpload>? Uploads { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUpload> Uploads { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_Dataset"/> and sets the default values.
        /// </summary>
        public Dlp_Dataset()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_Dataset"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_Dataset CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_Dataset();
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
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "encoding_version", n => { EncodingVersion = n.GetIntValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "num_cells", n => { NumCells = n.GetLongValue(); } },
                { "secret", n => { Secret = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUploadStatus>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "uploads", n => { Uploads = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUpload>(global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUpload.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("encoding_version", EncodingVersion);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("num_cells", NumCells);
            writer.WriteBoolValue("secret", Secret);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUploadStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Dlp_DatasetUpload>("uploads", Uploads);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
