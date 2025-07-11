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
    public partial class ApiShield_zone_schema_validation_settings_patch : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default mitigation action used when there is no mitigation action defined on the operationMitigation actions are as follows:  * `log` - log request when request does not conform to schema  * `block` - deny access to the site when request does not conform to schemaA special value of of `none` will skip running schema validation entirely for the request when there is no mitigation action defined on the operation`null` will have no effect.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_validation_default_mitigation_action_patch? ValidationDefaultMitigationAction { get; set; }
        /// <summary>When set, this overrides both zone level and operation level mitigation actions.  - `none` will skip running schema validation entirely for the requestTo clear any override, use the special value `disable_override``null` will have no effect.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_validation_override_mitigation_action_patch? ValidationOverrideMitigationAction { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_zone_schema_validation_settings_patch"/> and sets the default values.
        /// </summary>
        public ApiShield_zone_schema_validation_settings_patch()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_zone_schema_validation_settings_patch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_zone_schema_validation_settings_patch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_zone_schema_validation_settings_patch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "validation_default_mitigation_action", n => { ValidationDefaultMitigationAction = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_validation_default_mitigation_action_patch>(); } },
                { "validation_override_mitigation_action", n => { ValidationOverrideMitigationAction = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_validation_override_mitigation_action_patch>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_validation_default_mitigation_action_patch>("validation_default_mitigation_action", ValidationDefaultMitigationAction);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_validation_override_mitigation_action_patch>("validation_override_mitigation_action", ValidationOverrideMitigationAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
