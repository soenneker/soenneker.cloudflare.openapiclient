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
    public partial class Zero_trust_gateway_rules_create_zero_trust_gateway_rule_RequestBody_application_json : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action to preform when the associated traffic, identity, and device posture expressions are either absent or evaluate to `true`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_action? Action { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_action Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasDescription? Description { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasDescription Description { get; set; }
#endif
        /// <summary>The wirefilter expression used for device posture check matching.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_device_posture? DevicePosture { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_device_posture DevicePosture { get; set; }
#endif
        /// <summary>True if the rule is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_enabled? Enabled { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_enabled Enabled { get; set; }
#endif
        /// <summary>The expiration time stamp and default duration of a DNS policy. Takesprecedence over the policy&apos;s `schedule` configuration, if any.This does not apply to HTTP or network policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_expiration? Expiration { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_expiration Expiration { get; set; }
#endif
        /// <summary>The protocol or layer to evaluate the traffic, identity, and device posture expressions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules>? Filters { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules> Filters { get; set; }
#endif
        /// <summary>The wirefilter expression used for identity matching.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_identity? Identity { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_identity Identity { get; set; }
#endif
        /// <summary>The name of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_componentsSchemasName? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_componentsSchemasName Name { get; set; }
#endif
        /// <summary>Precedence sets the order of your rules. Lower values indicate higher precedence. At each processing phase, applicable rules are evaluated in ascending order of this value. Refer to [Order of enforcement](http://developers.cloudflare.com/learning-paths/secure-internet-traffic/understand-policies/order-of-enforcement/#manage-precedence-with-terraform) docs on how to manage precedence via Terraform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_precedence? Precedence { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_precedence Precedence { get; set; }
#endif
        /// <summary>Additional settings that modify the rule&apos;s action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings? RuleSettings { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings RuleSettings { get; set; }
#endif
        /// <summary>The schedule for activating DNS policies. This does not apply to HTTP or network policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schedule? Schedule { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schedule Schedule { get; set; }
#endif
        /// <summary>The wirefilter expression used for traffic matching.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_traffic? Traffic { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_traffic Traffic { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_gateway_rules_create_zero_trust_gateway_rule_RequestBody_application_json"/> and sets the default values.
        /// </summary>
        public Zero_trust_gateway_rules_create_zero_trust_gateway_rule_RequestBody_application_json()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_gateway_rules_create_zero_trust_gateway_rule_RequestBody_application_json"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_gateway_rules_create_zero_trust_gateway_rule_RequestBody_application_json CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Zero_trust_gateway_rules_create_zero_trust_gateway_rule_RequestBody_application_json();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_action>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_action.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasDescription>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasDescription.CreateFromDiscriminatorValue); } },
                { "device_posture", n => { DevicePosture = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_device_posture>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_device_posture.CreateFromDiscriminatorValue); } },
                { "enabled", n => { Enabled = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_enabled>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_enabled.CreateFromDiscriminatorValue); } },
                { "expiration", n => { Expiration = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_expiration>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_expiration.CreateFromDiscriminatorValue); } },
                { "filters", n => { Filters = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rules.CreateFromDiscriminatorValue)?.AsList(); } },
                { "identity", n => { Identity = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_identity>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_identity.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_componentsSchemasName>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_componentsSchemasName.CreateFromDiscriminatorValue); } },
                { "precedence", n => { Precedence = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_precedence>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_precedence.CreateFromDiscriminatorValue); } },
                { "rule_settings", n => { RuleSettings = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings.CreateFromDiscriminatorValue); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schedule>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schedule.CreateFromDiscriminatorValue); } },
                { "traffic", n => { Traffic = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_traffic>(global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_traffic.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_action>("action", Action);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schemasDescription>("description", Description);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_device_posture>("device_posture", DevicePosture);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_enabled>("enabled", Enabled);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_expiration>("expiration", Expiration);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Rules>("filters", Filters);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_identity>("identity", Identity);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_componentsSchemasName>("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_precedence>("precedence", Precedence);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings>("rule_settings", RuleSettings);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_schedule>("schedule", Schedule);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_traffic>("traffic", Traffic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
