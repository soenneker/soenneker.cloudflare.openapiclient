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
    public partial class Cloudflare_d1_export_database : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>To poll an in-progress export, provide the current bookmark (returned by your first polling response)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentBookmark { get; set; }
#nullable restore
#else
        public string CurrentBookmark { get; set; }
#endif
        /// <summary>The dump_options property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_dump_options? DumpOptions { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_dump_options DumpOptions { get; set; }
#endif
        /// <summary>Specifies that you will poll this endpoint until the export completes</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_output_format? OutputFormat { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database"/> and sets the default values.
        /// </summary>
        public Cloudflare_d1_export_database()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "current_bookmark", n => { CurrentBookmark = n.GetStringValue(); } },
                { "dump_options", n => { DumpOptions = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_dump_options>(global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_dump_options.CreateFromDiscriminatorValue); } },
                { "output_format", n => { OutputFormat = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_output_format>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("current_bookmark", CurrentBookmark);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_dump_options>("dump_options", DumpOptions);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_export_database_output_format>("output_format", OutputFormat);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
