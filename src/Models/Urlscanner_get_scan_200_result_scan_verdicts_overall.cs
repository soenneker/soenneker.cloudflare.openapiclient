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
    public partial class Urlscanner_get_scan_200_result_scan_verdicts_overall : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The categories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall_categories>? Categories { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall_categories> Categories { get; set; }
#endif
        /// <summary>At least one of our subsystems marked the site as potentially malicious at the time of the scan.</summary>
        public bool? Malicious { get; set; }
        /// <summary>The phishing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Phishing { get; set; }
#nullable restore
#else
        public List<string> Phishing { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall"/> and sets the default values.
        /// </summary>
        public Urlscanner_get_scan_200_result_scan_verdicts_overall()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall_categories>(global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall_categories.CreateFromDiscriminatorValue)?.AsList(); } },
                { "malicious", n => { Malicious = n.GetBoolValue(); } },
                { "phishing", n => { Phishing = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_200_result_scan_verdicts_overall_categories>("categories", Categories);
            writer.WriteBoolValue("malicious", Malicious);
            writer.WriteCollectionOfPrimitiveValues<string>("phishing", Phishing);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
