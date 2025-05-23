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
    /// List of IDs that will be used when dispatching a notification. IDs for email type will be the email address.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Aaa_mechanisms : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_email>? Email { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_email> Email { get; set; }
#endif
        /// <summary>The pagerduty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_pagerduty>? Pagerduty { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_pagerduty> Pagerduty { get; set; }
#endif
        /// <summary>The webhooks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_webhooks>? Webhooks { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_webhooks> Webhooks { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms"/> and sets the default values.
        /// </summary>
        public Aaa_mechanisms()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email", n => { Email = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_email>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_email.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagerduty", n => { Pagerduty = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_pagerduty>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_pagerduty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "webhooks", n => { Webhooks = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_webhooks>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_webhooks.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_email>("email", Email);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_pagerduty>("pagerduty", Pagerduty);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms_webhooks>("webhooks", Webhooks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
