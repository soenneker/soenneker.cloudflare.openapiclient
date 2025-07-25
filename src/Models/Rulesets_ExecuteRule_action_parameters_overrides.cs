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
    /// A set of overrides to apply to the target ruleset.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Rulesets_ExecuteRule_action_parameters_overrides : IAdditionalDataHolder, IParsable
    {
        /// <summary>The action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of category-level overrides. This option has the second-highest precedence after rule-level overrides.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_categories>? Categories { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_categories> Categories { get; set; }
#endif
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>A list of rule-level overrides. This option has the highest precedence.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_rules>? Rules { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_rules> Rules { get; set; }
#endif
        /// <summary>The sensitivity_level property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteSensitivityLevel? SensitivityLevel { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides"/> and sets the default values.
        /// </summary>
        public Rulesets_ExecuteRule_action_parameters_overrides()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetStringValue(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_categories>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_categories.CreateFromDiscriminatorValue)?.AsList(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_rules>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_rules.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sensitivity_level", n => { SensitivityLevel = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteSensitivityLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_categories>("categories", Categories);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteRule_action_parameters_overrides_rules>("rules", Rules);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_ExecuteSensitivityLevel>("sensitivity_level", SensitivityLevel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
