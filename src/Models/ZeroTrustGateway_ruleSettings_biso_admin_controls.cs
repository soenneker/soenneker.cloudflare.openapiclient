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
    /// Configure how browser isolation behaves.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ZeroTrustGateway_ruleSettings_biso_admin_controls : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Configure whether copy is enabled or not. When set with &quot;remote_only&quot;, copying isolated content from the remote browser to the user&apos;s local clipboard is disabled. When absent, copy is enabled. Only applies when `version == &quot;v2&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_copy? Copy { get; set; }
        /// <summary>Set to false to enable copy-pasting. Only applies when `version == &quot;v1&quot;`.</summary>
        public bool? Dcp { get; set; }
        /// <summary>Set to false to enable downloading. Only applies when `version == &quot;v1&quot;`.</summary>
        public bool? Dd { get; set; }
        /// <summary>Set to false to enable keyboard usage. Only applies when `version == &quot;v1&quot;`.</summary>
        public bool? Dk { get; set; }
        /// <summary>Configure whether downloading enabled or not. When set with &quot;remote_only&quot;, downloads are only available for viewing. Only applies when `version == &quot;v2&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_download? Download { get; set; }
        /// <summary>Set to false to enable printing. Only applies when `version == &quot;v1&quot;`.</summary>
        public bool? Dp { get; set; }
        /// <summary>Set to false to enable uploading. Only applies when `version == &quot;v1&quot;`.</summary>
        public bool? Du { get; set; }
        /// <summary>Configure whether keyboard usage is enabled or not. When absent, keyboard usage is enabled. Only applies when `version == &quot;v2&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_keyboard? Keyboard { get; set; }
        /// <summary>Configure whether pasting is enabled or not. When set with &quot;remote_only&quot;, pasting content from the user&apos;s local clipboard into isolated pages is disabled. When absent, paste is enabled. Only applies when `version == &quot;v2&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_paste? Paste { get; set; }
        /// <summary>Configure whether printing is enabled or not. When absent, printing is enabled. Only applies when `version == &quot;v2&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_printing? Printing { get; set; }
        /// <summary>Configure whether uploading is enabled or not. When absent, uploading is enabled. Only applies when `version == &quot;v2&quot;`.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_upload? Upload { get; set; }
        /// <summary>Indicates which version of the browser isolation controls should apply.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_version? Version { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls"/> and sets the default values.
        /// </summary>
        public ZeroTrustGateway_ruleSettings_biso_admin_controls()
        {
            AdditionalData = new Dictionary<string, object>();
            Version = global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_version.V1;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "copy", n => { Copy = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_copy>(); } },
                { "dcp", n => { Dcp = n.GetBoolValue(); } },
                { "dd", n => { Dd = n.GetBoolValue(); } },
                { "dk", n => { Dk = n.GetBoolValue(); } },
                { "download", n => { Download = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_download>(); } },
                { "dp", n => { Dp = n.GetBoolValue(); } },
                { "du", n => { Du = n.GetBoolValue(); } },
                { "keyboard", n => { Keyboard = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_keyboard>(); } },
                { "paste", n => { Paste = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_paste>(); } },
                { "printing", n => { Printing = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_printing>(); } },
                { "upload", n => { Upload = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_upload>(); } },
                { "version", n => { Version = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_version>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_copy>("copy", Copy);
            writer.WriteBoolValue("dcp", Dcp);
            writer.WriteBoolValue("dd", Dd);
            writer.WriteBoolValue("dk", Dk);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_download>("download", Download);
            writer.WriteBoolValue("dp", Dp);
            writer.WriteBoolValue("du", Du);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_keyboard>("keyboard", Keyboard);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_paste>("paste", Paste);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_printing>("printing", Printing);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_upload>("upload", Upload);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.ZeroTrustGateway_ruleSettings_biso_admin_controls_version>("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
