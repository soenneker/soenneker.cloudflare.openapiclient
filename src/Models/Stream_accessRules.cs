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
    /// Defines rules for fine-grained control over content than signed URL tokens alone. Access rules primarily make tokens conditionally valid based on user information. Access Rules are specified on token payloads as the `accessRules` property containing an array of Rule objects.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Stream_accessRules : IAdditionalDataHolder, IParsable
    {
        /// <summary>The action to take when a request matches a rule. If the action is `block`, the signed token blocks views for viewers matching the rule.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules_action? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An array of 2-letter country codes in ISO 3166-1 Alpha-2 format used to match requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Country { get; set; }
#nullable restore
#else
        public List<string> Country { get; set; }
#endif
        /// <summary>An array of IPv4 or IPV6 addresses or CIDRs used to match requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ip { get; set; }
#nullable restore
#else
        public List<string> Ip { get; set; }
#endif
        /// <summary>Lists available rule types to match for requests. An `any` type matches all requests and can be used as a wildcard to apply default actions after other rules.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules"/> and sets the default values.
        /// </summary>
        public Stream_accessRules()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules_action>(); } },
                { "country", n => { Country = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "ip", n => { Ip = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules_action>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("country", Country);
            writer.WriteCollectionOfPrimitiveValues<string>("ip", Ip);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Stream_accessRules_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
