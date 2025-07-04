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
    public partial class DigitalExperienceMonitoring_warp_toggle_change_event : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName { get; set; }
#nullable restore
#else
        public string AccountName { get; set; }
#endif
        /// <summary>The public account identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountTag { get; set; }
#nullable restore
#else
        public string AccountTag { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>API Resource UUID tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>API Resource UUID tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceRegistration { get; set; }
#nullable restore
#else
        public string DeviceRegistration { get; set; }
#endif
        /// <summary>The hostname of the machine the event is from</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname { get; set; }
#nullable restore
#else
        public string Hostname { get; set; }
#endif
        /// <summary>The serial number of the machine the event is from</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>Timestamp in ISO format</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Timestamp { get; set; }
#nullable restore
#else
        public string Timestamp { get; set; }
#endif
        /// <summary>The state of the WARP toggle.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event_toggle? Toggle { get; set; }
        /// <summary>Email tied to the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail { get; set; }
#nullable restore
#else
        public string UserEmail { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event"/> and sets the default values.
        /// </summary>
        public DigitalExperienceMonitoring_warp_toggle_change_event()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_name", n => { AccountName = n.GetStringValue(); } },
                { "account_tag", n => { AccountTag = n.GetStringValue(); } },
                { "device_id", n => { DeviceId = n.GetStringValue(); } },
                { "device_registration", n => { DeviceRegistration = n.GetStringValue(); } },
                { "hostname", n => { Hostname = n.GetStringValue(); } },
                { "serial_number", n => { SerialNumber = n.GetStringValue(); } },
                { "timestamp", n => { Timestamp = n.GetStringValue(); } },
                { "toggle", n => { Toggle = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event_toggle>(); } },
                { "user_email", n => { UserEmail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_name", AccountName);
            writer.WriteStringValue("account_tag", AccountTag);
            writer.WriteStringValue("device_id", DeviceId);
            writer.WriteStringValue("device_registration", DeviceRegistration);
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteStringValue("serial_number", SerialNumber);
            writer.WriteStringValue("timestamp", Timestamp);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_warp_toggle_change_event_toggle>("toggle", Toggle);
            writer.WriteStringValue("user_email", UserEmail);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
