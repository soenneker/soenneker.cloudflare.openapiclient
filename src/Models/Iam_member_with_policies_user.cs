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
    /// Details of the user associated to the membership.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Iam_member_with_policies_user : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contact email address of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_email? Email { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_email Email { get; set; }
#endif
        /// <summary>User&apos;s first name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_first_name? FirstName { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_first_name FirstName { get; set; }
#endif
        /// <summary>Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_common_componentsSchemasIdentifier? Id { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_common_componentsSchemasIdentifier Id { get; set; }
#endif
        /// <summary>User&apos;s last name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_last_name? LastName { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_last_name LastName { get; set; }
#endif
        /// <summary>Indicates whether two-factor authentication is enabled for the user account. Does not apply to API authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_two_factor_authentication_enabled? TwoFactorAuthenticationEnabled { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_two_factor_authentication_enabled TwoFactorAuthenticationEnabled { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_member_with_policies_user"/> and sets the default values.
        /// </summary>
        public Iam_member_with_policies_user()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_member_with_policies_user"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_member_with_policies_user CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_member_with_policies_user();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email", n => { Email = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_email>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_email.CreateFromDiscriminatorValue); } },
                { "first_name", n => { FirstName = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_first_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_first_name.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_common_componentsSchemasIdentifier>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_common_componentsSchemasIdentifier.CreateFromDiscriminatorValue); } },
                { "last_name", n => { LastName = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_last_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_last_name.CreateFromDiscriminatorValue); } },
                { "two_factor_authentication_enabled", n => { TwoFactorAuthenticationEnabled = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_two_factor_authentication_enabled>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_two_factor_authentication_enabled.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_email>("email", Email);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_first_name>("first_name", FirstName);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_common_componentsSchemasIdentifier>("id", Id);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_last_name>("last_name", LastName);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_two_factor_authentication_enabled>("two_factor_authentication_enabled", TwoFactorAuthenticationEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
