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
    public partial class R2_bucketLockRule : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The condition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition? Condition { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition Condition { get; set; }
#endif
        /// <summary>Whether or not this rule is in effect.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Unique identifier for this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Rule will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Prefix { get; set; }
#nullable restore
#else
        public string Prefix { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule"/> and sets the default values.
        /// </summary>
        public R2_bucketLockRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "condition", n => { Condition = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition>(global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition.CreateFromDiscriminatorValue); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "prefix", n => { Prefix = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition>("condition", Condition);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("prefix", Prefix);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleAgeCondition"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleDateCondition"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleIndefiniteCondition"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class R2_bucketLockRule_condition : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleAgeCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleAgeCondition? R2LockRuleAgeCondition { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleAgeCondition R2LockRuleAgeCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleDateCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleDateCondition? R2LockRuleDateCondition { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleDateCondition R2LockRuleDateCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleIndefiniteCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleIndefiniteCondition? R2LockRuleIndefiniteCondition { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleIndefiniteCondition R2LockRuleIndefiniteCondition { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.R2_bucketLockRule.R2_bucketLockRule_condition();
                if("r2_lock-rule-age-condition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.R2LockRuleAgeCondition = new global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleAgeCondition();
                }
                else if("r2_lock-rule-date-condition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.R2LockRuleDateCondition = new global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleDateCondition();
                }
                else if("r2_lock-rule-indefinite-condition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.R2LockRuleIndefiniteCondition = new global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleIndefiniteCondition();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(R2LockRuleAgeCondition != null)
                {
                    return R2LockRuleAgeCondition.GetFieldDeserializers();
                }
                else if(R2LockRuleDateCondition != null)
                {
                    return R2LockRuleDateCondition.GetFieldDeserializers();
                }
                else if(R2LockRuleIndefiniteCondition != null)
                {
                    return R2LockRuleIndefiniteCondition.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(R2LockRuleAgeCondition != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleAgeCondition>(null, R2LockRuleAgeCondition);
                }
                else if(R2LockRuleDateCondition != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleDateCondition>(null, R2LockRuleDateCondition);
                }
                else if(R2LockRuleIndefiniteCondition != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.R2_lockRuleIndefiniteCondition>(null, R2LockRuleIndefiniteCondition);
                }
            }
        }
    }
}
#pragma warning restore CS0618
