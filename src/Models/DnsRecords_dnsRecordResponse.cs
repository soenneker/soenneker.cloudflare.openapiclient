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
    public partial class DnsRecords_dnsRecordResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>When the record comment was last modified. Omitted if there is no comment.</summary>
        public DateTimeOffset? CommentModifiedOn { get; private set; }
        /// <summary>When the record was created.</summary>
        public DateTimeOffset? CreatedOn { get; private set; }
        /// <summary>Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Extra Cloudflare-specific information about the record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse_meta? Meta { get; private set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse_meta Meta { get; private set; }
#endif
        /// <summary>When the record was last modified.</summary>
        public DateTimeOffset? ModifiedOn { get; private set; }
        /// <summary>Whether the record can be proxied by Cloudflare or not.</summary>
        public bool? Proxiable { get; private set; }
        /// <summary>When the record tags were last modified. Omitted if there are no tags.</summary>
        public DateTimeOffset? TagsModifiedOn { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse"/> and sets the default values.
        /// </summary>
        public DnsRecords_dnsRecordResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comment_modified_on", n => { CommentModifiedOn = n.GetDateTimeOffsetValue(); } },
                { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "meta", n => { Meta = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse_meta>(global::Soenneker.Cloudflare.OpenApiClient.Models.DnsRecords_dnsRecordResponse_meta.CreateFromDiscriminatorValue); } },
                { "modified_on", n => { ModifiedOn = n.GetDateTimeOffsetValue(); } },
                { "proxiable", n => { Proxiable = n.GetBoolValue(); } },
                { "tags_modified_on", n => { TagsModifiedOn = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
