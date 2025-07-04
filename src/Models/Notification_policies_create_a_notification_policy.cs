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
    public partial class Notification_policies_create_a_notification_policy : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional specification of how often to re-alert from the same incident, not support on all alert types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertInterval { get; set; }
#nullable restore
#else
        public string AlertInterval { get; set; }
#endif
        /// <summary>Refers to which event will trigger a Notification dispatch. You can use the endpoint to get available alert types which then will give you a list of possible values.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type? AlertType { get; set; }
        /// <summary>Optional description for the Notification policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Whether or not the Notification policy is enabled.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Optional filters that allow you to be alerted only on a subset of events for that alert type based on some criteria. This is only available for select alert types. See alert type documentation for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters? Filters { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters Filters { get; set; }
#endif
        /// <summary>List of IDs that will be used when dispatching a notification. IDs for email type will be the email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms? Mechanisms { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms Mechanisms { get; set; }
#endif
        /// <summary>Name of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Notification_policies_create_a_notification_policy"/> and sets the default values.
        /// </summary>
        public Notification_policies_create_a_notification_policy()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Notification_policies_create_a_notification_policy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Notification_policies_create_a_notification_policy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Notification_policies_create_a_notification_policy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alert_interval", n => { AlertInterval = n.GetStringValue(); } },
                { "alert_type", n => { AlertType = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "filters", n => { Filters = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters.CreateFromDiscriminatorValue); } },
                { "mechanisms", n => { Mechanisms = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alert_interval", AlertInterval);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_alert_type>("alert_type", AlertType);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_filters>("filters", Filters);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_mechanisms>("mechanisms", Mechanisms);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
