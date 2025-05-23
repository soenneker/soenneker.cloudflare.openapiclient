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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingDisabled"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingEnabled"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Hyperdrive_hyperdriveCaching : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingDisabled"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingDisabled? HyperdriveHyperdriveCachingDisabled { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingDisabled HyperdriveHyperdriveCachingDisabled { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingEnabled"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingEnabled? HyperdriveHyperdriveCachingEnabled { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingEnabled HyperdriveHyperdriveCachingEnabled { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCaching"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCaching CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("disabled")?.GetStringValue();
            var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCaching();
            if("hyperdrive_hyperdrive-caching-disabled".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.HyperdriveHyperdriveCachingDisabled = new global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingDisabled();
            }
            else if("hyperdrive_hyperdrive-caching-enabled".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.HyperdriveHyperdriveCachingEnabled = new global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingEnabled();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(HyperdriveHyperdriveCachingDisabled != null)
            {
                return HyperdriveHyperdriveCachingDisabled.GetFieldDeserializers();
            }
            else if(HyperdriveHyperdriveCachingEnabled != null)
            {
                return HyperdriveHyperdriveCachingEnabled.GetFieldDeserializers();
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
            if(HyperdriveHyperdriveCachingDisabled != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingDisabled>(null, HyperdriveHyperdriveCachingDisabled);
            }
            else if(HyperdriveHyperdriveCachingEnabled != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Hyperdrive_hyperdriveCachingEnabled>(null, HyperdriveHyperdriveCachingEnabled);
            }
        }
    }
}
#pragma warning restore CS0618
