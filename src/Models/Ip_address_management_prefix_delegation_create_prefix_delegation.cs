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
    public partial class Ip_address_management_prefix_delegation_create_prefix_delegation : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>IP Prefix in Classless Inter-Domain Routing format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cidr { get; set; }
#nullable restore
#else
        public string Cidr { get; set; }
#endif
        /// <summary>Account identifier for the account to which prefix is being delegated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DelegatedAccountId { get; set; }
#nullable restore
#else
        public string DelegatedAccountId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Ip_address_management_prefix_delegation_create_prefix_delegation"/> and sets the default values.
        /// </summary>
        public Ip_address_management_prefix_delegation_create_prefix_delegation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Ip_address_management_prefix_delegation_create_prefix_delegation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Ip_address_management_prefix_delegation_create_prefix_delegation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Ip_address_management_prefix_delegation_create_prefix_delegation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cidr", n => { Cidr = n.GetStringValue(); } },
                { "delegated_account_id", n => { DelegatedAccountId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cidr", Cidr);
            writer.WriteStringValue("delegated_account_id", DelegatedAccountId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
