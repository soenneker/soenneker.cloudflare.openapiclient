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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_apiResponseCollection"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collectionMember1"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Firewall_package_response_collection : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_apiResponseCollection"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_apiResponseCollection? FirewallApiResponseCollection { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_apiResponseCollection FirewallApiResponseCollection { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collectionMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collectionMember1? FirewallPackageResponseCollectionMember1 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collectionMember1 FirewallPackageResponseCollectionMember1 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collection();
            result.FirewallApiResponseCollection = new global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_apiResponseCollection();
            result.FirewallPackageResponseCollectionMember1 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_package_response_collectionMember1();
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(FirewallApiResponseCollection != null || FirewallPackageResponseCollectionMember1 != null)
            {
                return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(FirewallApiResponseCollection, FirewallPackageResponseCollectionMember1);
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
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Firewall_apiResponseCollection>(null, FirewallApiResponseCollection, FirewallPackageResponseCollectionMember1);
        }
    }
}
#pragma warning restore CS0618
