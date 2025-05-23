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
    public partial class Aaa_policies : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional specification of how often to re-alert from the same incident, not support on all alert types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_interval? AlertInterval { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_interval AlertInterval { get; set; }
#endif
        /// <summary>Refers to which event will trigger a Notification dispatch. You can use the endpoint to get available alert types which then will give you a list of possible values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type? AlertType { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type AlertType { get; set; }
#endif
        /// <summary>The created property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp? Created { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp Created { get; set; }
#endif
        /// <summary>Optional description for the Notification policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasDescription? Description { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasDescription Description { get; set; }
#endif
        /// <summary>Whether or not the Notification policy is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_enabled? Enabled { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_enabled Enabled { get; set; }
#endif
        /// <summary>Optional filters that allow you to be alerted only on a subset of events for that alert type based on some criteria. This is only available for select alert types. See alert type documentation for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters? Filters { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters Filters { get; set; }
#endif
        /// <summary>The unique identifier of a notification policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policyId? Id { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policyId Id { get; set; }
#endif
        /// <summary>List of IDs that will be used when dispatching a notification. IDs for email type will be the email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms? Mechanisms { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms Mechanisms { get; set; }
#endif
        /// <summary>The modified property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp? Modified { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp Modified { get; set; }
#endif
        /// <summary>Name of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasName? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasName Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policies"/> and sets the default values.
        /// </summary>
        public Aaa_policies()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policies"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policies CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policies();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alert_interval", n => { AlertInterval = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_interval>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_interval.CreateFromDiscriminatorValue); } },
                { "alert_type", n => { AlertType = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type.CreateFromDiscriminatorValue); } },
                { "created", n => { Created = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasDescription>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasDescription.CreateFromDiscriminatorValue); } },
                { "enabled", n => { Enabled = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_enabled>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_enabled.CreateFromDiscriminatorValue); } },
                { "filters", n => { Filters = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policyId>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policyId.CreateFromDiscriminatorValue); } },
                { "mechanisms", n => { Mechanisms = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms.CreateFromDiscriminatorValue); } },
                { "modified", n => { Modified = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasName>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasName.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_interval>("alert_interval", AlertInterval);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type>("alert_type", AlertType);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp>("created", Created);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasDescription>("description", Description);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_enabled>("enabled", Enabled);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters>("filters", Filters);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_policyId>("id", Id);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms>("mechanisms", Mechanisms);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_timestamp>("modified", Modified);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_schemasName>("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
