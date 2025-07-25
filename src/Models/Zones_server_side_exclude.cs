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
    /// If there is sensitive content on your website that you want visible to real visitors, but that you want to hide from suspicious visitors, all you have to do is wrap the content with Cloudflare SSE tags. Wrap any content that you want to be excluded from suspicious visitors in the following SSE tags: &lt;!--sse--&gt;&lt;!--/sse--&gt;. For example: &lt;!--sse--&gt;  Bad visitors won&apos;t see my phone number, 555-555-5555 &lt;!--/sse--&gt;. Note: SSE only will work with HTML. If you have HTML minification enabled, you won&apos;t see the SSE tags in your HTML source when it&apos;s served through Cloudflare. SSE will still function in this case, as Cloudflare&apos;s HTML minification and SSE functionality occur on-the-fly as the resource moves through our network to the visitor&apos;s computer. (https://support.cloudflare.com/hc/en-us/articles/200170036).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Zones_server_side_exclude : global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_base, IParsable
    {
        /// <summary>Value of the zone setting.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude_value? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude"/> and sets the default values.
        /// </summary>
        public Zones_server_side_exclude() : base()
        {
            Value = global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude_value.On;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "value", n => { Value = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude_value>(); } },
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
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_server_side_exclude_value>("value", Value);
        }
    }
}
#pragma warning restore CS0618
