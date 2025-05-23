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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember1"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember2"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember3"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Waitingroom_rule_position : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember1? WaitingroomRulePositionMember1 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember1 WaitingroomRulePositionMember1 { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember2? WaitingroomRulePositionMember2 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember2 WaitingroomRulePositionMember2 { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember3"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember3? WaitingroomRulePositionMember3 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember3 WaitingroomRulePositionMember3 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_position"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_position CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_position();
            if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WaitingroomRulePositionMember1 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember1();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WaitingroomRulePositionMember2 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember2();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WaitingroomRulePositionMember3 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember3();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(WaitingroomRulePositionMember1 != null)
            {
                return WaitingroomRulePositionMember1.GetFieldDeserializers();
            }
            else if(WaitingroomRulePositionMember2 != null)
            {
                return WaitingroomRulePositionMember2.GetFieldDeserializers();
            }
            else if(WaitingroomRulePositionMember3 != null)
            {
                return WaitingroomRulePositionMember3.GetFieldDeserializers();
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
            if(WaitingroomRulePositionMember1 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember1>(null, WaitingroomRulePositionMember1);
            }
            else if(WaitingroomRulePositionMember2 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember2>(null, WaitingroomRulePositionMember2);
            }
            else if(WaitingroomRulePositionMember3 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_rule_positionMember3>(null, WaitingroomRulePositionMember3);
            }
        }
    }
}
#pragma warning restore CS0618
