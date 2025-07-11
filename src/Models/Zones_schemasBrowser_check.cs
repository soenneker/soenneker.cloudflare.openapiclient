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
    /// Browser Integrity Check is similar to Bad Behavior and looks for common HTTP headers abused most commonly by spammers and denies access to your page.  It will also challenge visitors that do not have a user agent or a non standard user agent (also commonly used by abuse bots, crawlers or visitors). (https://support.cloudflare.com/hc/en-us/articles/200170086).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Zones_schemasBrowser_check : global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_base, IParsable
    {
        /// <summary>The value property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_schemasBrowser_check_value? Value { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_schemasBrowser_check"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_schemasBrowser_check CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_schemasBrowser_check();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "value", n => { Value = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_schemasBrowser_check_value>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_schemasBrowser_check_value>("value", Value);
        }
    }
}
#pragma warning restore CS0618
