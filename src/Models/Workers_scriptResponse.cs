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
    public partial class Workers_scriptResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>When the script was created.</summary>
        public DateTimeOffset? CreatedOn { get; private set; }
        /// <summary>Hashed script content, can be used in a If-None-Match header when updating.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag { get; private set; }
#nullable restore
#else
        public string Etag { get; private set; }
#endif
        /// <summary>Whether a Worker contains assets.</summary>
        public bool? HasAssets { get; set; }
        /// <summary>Whether a Worker contains modules.</summary>
        public bool? HasModules { get; set; }
        /// <summary>The id of the script in the Workers system. Usually the script name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>Whether Logpush is turned on for the Worker.</summary>
        public bool? Logpush { get; set; }
        /// <summary>When the script was last modified.</summary>
        public DateTimeOffset? ModifiedOn { get; private set; }
        /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_info? Placement { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_info Placement { get; set; }
#endif
        /// <summary>The placement_mode property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_mode? PlacementMode { get; set; }
        /// <summary>The placement_status property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_status? PlacementStatus { get; set; }
        /// <summary>List of Workers that will consume logs from the attached Worker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_tail_consumers_script>? TailConsumers { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_tail_consumers_script> TailConsumers { get; set; }
#endif
        /// <summary>Usage model for the Worker invocations.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_usage_model? UsageModel { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_scriptResponse"/> and sets the default values.
        /// </summary>
        public Workers_scriptResponse()
        {
            AdditionalData = new Dictionary<string, object>();
            UsageModel = global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_usage_model.Standard;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_scriptResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_scriptResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_scriptResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
                { "etag", n => { Etag = n.GetStringValue(); } },
                { "has_assets", n => { HasAssets = n.GetBoolValue(); } },
                { "has_modules", n => { HasModules = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "logpush", n => { Logpush = n.GetBoolValue(); } },
                { "modified_on", n => { ModifiedOn = n.GetDateTimeOffsetValue(); } },
                { "placement", n => { Placement = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_info>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_info.CreateFromDiscriminatorValue); } },
                { "placement_mode", n => { PlacementMode = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_mode>(); } },
                { "placement_status", n => { PlacementStatus = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_status>(); } },
                { "tail_consumers", n => { TailConsumers = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_tail_consumers_script>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_tail_consumers_script.CreateFromDiscriminatorValue)?.AsList(); } },
                { "usage_model", n => { UsageModel = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_usage_model>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("has_assets", HasAssets);
            writer.WriteBoolValue("has_modules", HasModules);
            writer.WriteBoolValue("logpush", Logpush);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_info>("placement", Placement);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_mode>("placement_mode", PlacementMode);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_placement_status>("placement_status", PlacementStatus);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_tail_consumers_script>("tail_consumers", TailConsumers);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_usage_model>("usage_model", UsageModel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
