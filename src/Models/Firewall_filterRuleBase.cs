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
    public partial class Firewall_filterRuleBase : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action to apply to a matched request. The `log` action is only available on an Enterprise plan.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_schemasAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An informative summary of the firewall rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The unique identifier of the firewall rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>When true, indicates that the firewall rule is currently paused.</summary>
        public bool? Paused { get; set; }
        /// <summary>The priority of the rule. Optional value used to define the processing order. A lower number indicates a higher priority. If not provided, rules with a defined priority will be processed before rules without a priority.</summary>
        public double? Priority { get; set; }
        /// <summary>The products property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules?>? Products { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules?> Products { get; set; }
#endif
        /// <summary>A short reference tag. Allows you to select related firewall rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_filterRuleBase"/> and sets the default values.
        /// </summary>
        public Firewall_filterRuleBase()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_filterRuleBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_filterRuleBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_filterRuleBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_schemasAction>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "paused", n => { Paused = n.GetBoolValue(); } },
                { "priority", n => { Priority = n.GetDoubleValue(); } },
                { "products", n => { Products = n.GetCollectionOfEnumValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules>()?.AsList(); } },
                { "ref", n => { Ref = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_schemasAction>("action", Action);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("paused", Paused);
            writer.WriteDoubleValue("priority", Priority);
            writer.WriteCollectionOfEnumValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules>("products", Products);
            writer.WriteStringValue("ref", Ref);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
