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
    public partial class Zones_0_hold_patch : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If `hold_after` is provided and future-dated, the hold will be temporarily disabled,then automatically re-enabled by the system at the time specifiedin this RFC3339-formatted timestamp. A past-dated `hold_after` value will haveno effect on an existing, enabled hold. Providing an empty string will set its valueto the current time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HoldAfter { get; set; }
#nullable restore
#else
        public string HoldAfter { get; set; }
#endif
        /// <summary>If `true`, the zone hold will extend to block any subdomain of the given zone, as wellas SSL4SaaS Custom Hostnames. For example, a zone hold on a zone with the hostname&apos;example.com&apos; and include_subdomains=true will block &apos;example.com&apos;,&apos;staging.example.com&apos;, &apos;api.staging.example.com&apos;, etc.</summary>
        public bool? IncludeSubdomains { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_0_hold_patch"/> and sets the default values.
        /// </summary>
        public Zones_0_hold_patch()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_0_hold_patch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_0_hold_patch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Zones_0_hold_patch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hold_after", n => { HoldAfter = n.GetStringValue(); } },
                { "include_subdomains", n => { IncludeSubdomains = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("hold_after", HoldAfter);
            writer.WriteBoolValue("include_subdomains", IncludeSubdomains);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
