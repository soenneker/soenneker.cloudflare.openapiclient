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
    public partial class Post_EventCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accountId property</summary>
        public double? AccountId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attacker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Attacker { get; set; }
#nullable restore
#else
        public string Attacker { get; set; }
#endif
        /// <summary>The attackerCountry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttackerCountry { get; set; }
#nullable restore
#else
        public string AttackerCountry { get; set; }
#endif
        /// <summary>The category property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>The datasetId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatasetId { get; set; }
#nullable restore
#else
        public string DatasetId { get; set; }
#endif
        /// <summary>The date property</summary>
        public DateTimeOffset? Date { get; set; }
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The indicator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Indicator { get; set; }
#nullable restore
#else
        public string Indicator { get; set; }
#endif
        /// <summary>The indicatorType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndicatorType { get; set; }
#nullable restore
#else
        public string IndicatorType { get; set; }
#endif
        /// <summary>The raw property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate_raw? Raw { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate_raw Raw { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The targetCountry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetCountry { get; set; }
#nullable restore
#else
        public string TargetCountry { get; set; }
#endif
        /// <summary>The targetIndustry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetIndustry { get; set; }
#nullable restore
#else
        public string TargetIndustry { get; set; }
#endif
        /// <summary>The tlp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tlp { get; set; }
#nullable restore
#else
        public string Tlp { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate"/> and sets the default values.
        /// </summary>
        public Post_EventCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountId", n => { AccountId = n.GetDoubleValue(); } },
                { "attacker", n => { Attacker = n.GetStringValue(); } },
                { "attackerCountry", n => { AttackerCountry = n.GetStringValue(); } },
                { "category", n => { Category = n.GetStringValue(); } },
                { "datasetId", n => { DatasetId = n.GetStringValue(); } },
                { "date", n => { Date = n.GetDateTimeOffsetValue(); } },
                { "event", n => { Event = n.GetStringValue(); } },
                { "indicator", n => { Indicator = n.GetStringValue(); } },
                { "indicatorType", n => { IndicatorType = n.GetStringValue(); } },
                { "raw", n => { Raw = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate_raw>(global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate_raw.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "targetCountry", n => { TargetCountry = n.GetStringValue(); } },
                { "targetIndustry", n => { TargetIndustry = n.GetStringValue(); } },
                { "tlp", n => { Tlp = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("accountId", AccountId);
            writer.WriteStringValue("attacker", Attacker);
            writer.WriteStringValue("attackerCountry", AttackerCountry);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("datasetId", DatasetId);
            writer.WriteDateTimeOffsetValue("date", Date);
            writer.WriteStringValue("event", Event);
            writer.WriteStringValue("indicator", Indicator);
            writer.WriteStringValue("indicatorType", IndicatorType);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Post_EventCreate_raw>("raw", Raw);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("targetCountry", TargetCountry);
            writer.WriteStringValue("targetIndustry", TargetIndustry);
            writer.WriteStringValue("tlp", Tlp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
