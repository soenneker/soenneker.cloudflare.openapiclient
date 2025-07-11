// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Intel_whois : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_date property</summary>
        public Date? CreatedDate { get; set; }
        /// <summary>The domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>The nameservers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Nameservers { get; set; }
#nullable restore
#else
        public List<string> Nameservers { get; set; }
#endif
        /// <summary>The registrant property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Registrant { get; set; }
#nullable restore
#else
        public string Registrant { get; set; }
#endif
        /// <summary>The registrant_country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrantCountry { get; set; }
#nullable restore
#else
        public string RegistrantCountry { get; set; }
#endif
        /// <summary>The registrant_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrantEmail { get; set; }
#nullable restore
#else
        public string RegistrantEmail { get; set; }
#endif
        /// <summary>The registrant_org property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrantOrg { get; set; }
#nullable restore
#else
        public string RegistrantOrg { get; set; }
#endif
        /// <summary>The registrar property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Registrar { get; set; }
#nullable restore
#else
        public string Registrar { get; set; }
#endif
        /// <summary>The updated_date property</summary>
        public Date? UpdatedDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Intel_whois"/> and sets the default values.
        /// </summary>
        public Intel_whois()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Intel_whois"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Intel_whois CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Intel_whois();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_date", n => { CreatedDate = n.GetDateValue(); } },
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "nameservers", n => { Nameservers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "registrant", n => { Registrant = n.GetStringValue(); } },
                { "registrant_country", n => { RegistrantCountry = n.GetStringValue(); } },
                { "registrant_email", n => { RegistrantEmail = n.GetStringValue(); } },
                { "registrant_org", n => { RegistrantOrg = n.GetStringValue(); } },
                { "registrar", n => { Registrar = n.GetStringValue(); } },
                { "updated_date", n => { UpdatedDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("created_date", CreatedDate);
            writer.WriteStringValue("domain", Domain);
            writer.WriteCollectionOfPrimitiveValues<string>("nameservers", Nameservers);
            writer.WriteStringValue("registrant", Registrant);
            writer.WriteStringValue("registrant_country", RegistrantCountry);
            writer.WriteStringValue("registrant_email", RegistrantEmail);
            writer.WriteStringValue("registrant_org", RegistrantOrg);
            writer.WriteStringValue("registrar", Registrar);
            writer.WriteDateValue("updated_date", UpdatedDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
