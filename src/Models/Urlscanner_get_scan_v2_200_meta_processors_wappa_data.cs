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
    public partial class Urlscanner_get_scan_v2_200_meta_processors_wappa_data : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The app property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? App { get; set; }
#nullable restore
#else
        public string App { get; set; }
#endif
        /// <summary>The categories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_categories>? Categories { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_categories> Categories { get; set; }
#endif
        /// <summary>The confidence property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_confidence>? Confidence { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_confidence> Confidence { get; set; }
#endif
        /// <summary>The confidenceTotal property</summary>
        public double? ConfidenceTotal { get; set; }
        /// <summary>The icon property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Icon { get; set; }
#nullable restore
#else
        public string Icon { get; set; }
#endif
        /// <summary>The website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data"/> and sets the default values.
        /// </summary>
        public Urlscanner_get_scan_v2_200_meta_processors_wappa_data()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "app", n => { App = n.GetStringValue(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_categories>(global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_categories.CreateFromDiscriminatorValue)?.AsList(); } },
                { "confidence", n => { Confidence = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_confidence>(global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_confidence.CreateFromDiscriminatorValue)?.AsList(); } },
                { "confidenceTotal", n => { ConfidenceTotal = n.GetDoubleValue(); } },
                { "icon", n => { Icon = n.GetStringValue(); } },
                { "website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("app", App);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_categories>("categories", Categories);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_v2_200_meta_processors_wappa_data_confidence>("confidence", Confidence);
            writer.WriteDoubleValue("confidenceTotal", ConfidenceTotal);
            writer.WriteStringValue("icon", Icon);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
