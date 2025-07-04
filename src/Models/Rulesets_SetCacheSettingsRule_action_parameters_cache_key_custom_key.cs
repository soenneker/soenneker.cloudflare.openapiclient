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
    /// Customize which components of the request are included or excluded from the cache key.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cookies to include in building the cache key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_cookie? Cookie { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_cookie Cookie { get; set; }
#endif
        /// <summary>The header names and values to include in building the cache key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_header? Header { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_header Header { get; set; }
#endif
        /// <summary>Whether to use the original host or the resolved host in the cache key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_host? Host { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_host Host { get; set; }
#endif
        /// <summary>The query_string property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string? QueryString { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string QueryString { get; set; }
#endif
        /// <summary>Characteristics of the request user agent used in building the cache key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_user? User { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_user User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key"/> and sets the default values.
        /// </summary>
        public Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cookie", n => { Cookie = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_cookie>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_cookie.CreateFromDiscriminatorValue); } },
                { "header", n => { Header = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_header>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_header.CreateFromDiscriminatorValue); } },
                { "host", n => { Host = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_host>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_host.CreateFromDiscriminatorValue); } },
                { "query_string", n => { QueryString = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string.CreateFromDiscriminatorValue); } },
                { "user", n => { User = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_user>(global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_user.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_cookie>("cookie", Cookie);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_header>("header", Header);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_host>("host", Host);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string>("query_string", QueryString);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_user>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember1"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember2"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember1? RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember1 RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember2? RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember2 RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_string();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember2();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1 != null)
                {
                    return RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1.GetFieldDeserializers();
                }
                else if(RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2 != null)
                {
                    return RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2.GetFieldDeserializers();
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
                if(RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember1>(null, RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember1);
                }
                else if(RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Rulesets_SetCacheSettingsRule_action_parameters_cache_key_custom_key_query_stringMember2>(null, RulesetsSetCacheSettingsRuleActionParametersCacheKeyCustomKeyQueryStringMember2);
                }
            }
        }
    }
}
#pragma warning restore CS0618
