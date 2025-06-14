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
    public partial class Access_schemasPolicy_check_response_result_user_identity : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The device_sessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_device_sessions? DeviceSessions { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_device_sessions DeviceSessions { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The geo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_geo? Geo { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_geo Geo { get; set; }
#endif
        /// <summary>The iat property</summary>
        public int? Iat { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The is_gateway property</summary>
        public bool? IsGateway { get; set; }
        /// <summary>The is_warp property</summary>
        public bool? IsWarp { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>UUID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserUuid { get; set; }
#nullable restore
#else
        public string UserUuid { get; set; }
#endif
        /// <summary>The version property</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity"/> and sets the default values.
        /// </summary>
        public Access_schemasPolicy_check_response_result_user_identity()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_id", n => { AccountId = n.GetStringValue(); } },
                { "device_sessions", n => { DeviceSessions = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_device_sessions>(global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_device_sessions.CreateFromDiscriminatorValue); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "geo", n => { Geo = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_geo>(global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_geo.CreateFromDiscriminatorValue); } },
                { "iat", n => { Iat = n.GetIntValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "is_gateway", n => { IsGateway = n.GetBoolValue(); } },
                { "is_warp", n => { IsWarp = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "user_uuid", n => { UserUuid = n.GetStringValue(); } },
                { "version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_id", AccountId);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_device_sessions>("device_sessions", DeviceSessions);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Access_schemasPolicy_check_response_result_user_identity_geo>("geo", Geo);
            writer.WriteIntValue("iat", Iat);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("is_gateway", IsGateway);
            writer.WriteBoolValue("is_warp", IsWarp);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("user_uuid", UserUuid);
            writer.WriteIntValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
