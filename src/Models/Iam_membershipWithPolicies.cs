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
    public partial class Iam_membershipWithPolicies : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasAccount? Account { get; private set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasAccount Account { get; private set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enterprise only. Indicates whether or not API access is enabled specifically for this user on a given account.</summary>
        public bool? ApiAccessEnabled { get; set; }
        /// <summary>Membership identifier tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>All access permissions for the user at the account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_permissions? Permissions { get; private set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_permissions Permissions { get; private set; }
#endif
        /// <summary>Access policy for the membership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_list_member_policy>? Policies { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_list_member_policy> Policies { get; set; }
#endif
        /// <summary>List of role names the membership has for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Roles { get; private set; }
#nullable restore
#else
        public List<string> Roles { get; private set; }
#endif
        /// <summary>Status of this membership.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_membershipWithPolicies"/> and sets the default values.
        /// </summary>
        public Iam_membershipWithPolicies()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_membershipWithPolicies"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_membershipWithPolicies CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_membershipWithPolicies();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account", n => { Account = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasAccount>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasAccount.CreateFromDiscriminatorValue); } },
                { "api_access_enabled", n => { ApiAccessEnabled = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "permissions", n => { Permissions = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_permissions>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_permissions.CreateFromDiscriminatorValue); } },
                { "policies", n => { Policies = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_list_member_policy>(global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_list_member_policy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roles", n => { Roles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("api_access_enabled", ApiAccessEnabled);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_list_member_policy>("policies", Policies);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Iam_schemasStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
