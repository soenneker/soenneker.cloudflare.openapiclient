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
    public partial class TlsCertificatesAndHostnames_per_hostname_settings_response_collection_result : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>This is the time the tls setting was originally created for this hostname.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The hostname for which the tls settings are set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname { get; set; }
#nullable restore
#else
        public string Hostname { get; set; }
#endif
        /// <summary>Deployment status for the given tls setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>This is the time the tls setting was updated.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The tls setting value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_value? Value { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_per_hostname_settings_response_collection_result"/> and sets the default values.
        /// </summary>
        public TlsCertificatesAndHostnames_per_hostname_settings_response_collection_result()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_per_hostname_settings_response_collection_result"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_per_hostname_settings_response_collection_result CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_per_hostname_settings_response_collection_result();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "hostname", n => { Hostname = n.GetStringValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "value", n => { Value = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_value>(global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteStringValue("status", Status);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
