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
    public partial class TeamsDevices_devices : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>When the device was created.</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>True if the device was deleted.</summary>
        public bool? Deleted { get; set; }
        /// <summary>The device_type property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_platform? DeviceType { get; set; }
        /// <summary>Registration ID. Equal to Device ID except for accounts which enabled [multi-user mode](https://developers.cloudflare.com/cloudflare-one/connections/connect-devices/warp/deployment/mdm-deployment/windows-multiuser/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>IPv4 or IPv6 address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ip { get; set; }
#nullable restore
#else
        public string Ip { get; set; }
#endif
        /// <summary>The device&apos;s public key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>When the device last connected to Cloudflare services.</summary>
        public DateTimeOffset? LastSeen { get; set; }
        /// <summary>The device mac address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress { get; set; }
#nullable restore
#else
        public string MacAddress { get; set; }
#endif
        /// <summary>The device manufacturer name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The device model name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>The device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Linux distro name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDistroName { get; set; }
#nullable restore
#else
        public string OsDistroName { get; set; }
#endif
        /// <summary>The Linux distro revision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDistroRevision { get; set; }
#nullable restore
#else
        public string OsDistroRevision { get; set; }
#endif
        /// <summary>The operating system version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>The operating system version extra parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersionExtra { get; set; }
#nullable restore
#else
        public string OsVersionExtra { get; set; }
#endif
        /// <summary>When the device was revoked.</summary>
        public DateTimeOffset? RevokedAt { get; set; }
        /// <summary>The device serial number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>When the device was updated.</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user? User { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user User { get; set; }
#endif
        /// <summary>The WARP client version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_devices"/> and sets the default values.
        /// </summary>
        public TeamsDevices_devices()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_devices"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_devices CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_devices();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created", n => { Created = n.GetDateTimeOffsetValue(); } },
                { "deleted", n => { Deleted = n.GetBoolValue(); } },
                { "device_type", n => { DeviceType = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_platform>(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "ip", n => { Ip = n.GetStringValue(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "last_seen", n => { LastSeen = n.GetDateTimeOffsetValue(); } },
                { "mac_address", n => { MacAddress = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "os_distro_name", n => { OsDistroName = n.GetStringValue(); } },
                { "os_distro_revision", n => { OsDistroRevision = n.GetStringValue(); } },
                { "os_version", n => { OsVersion = n.GetStringValue(); } },
                { "os_version_extra", n => { OsVersionExtra = n.GetStringValue(); } },
                { "revoked_at", n => { RevokedAt = n.GetDateTimeOffsetValue(); } },
                { "serial_number", n => { SerialNumber = n.GetStringValue(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
                { "user", n => { User = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user>(global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user.CreateFromDiscriminatorValue); } },
                { "version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteBoolValue("deleted", Deleted);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_platform>("device_type", DeviceType);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("ip", Ip);
            writer.WriteStringValue("key", Key);
            writer.WriteDateTimeOffsetValue("last_seen", LastSeen);
            writer.WriteStringValue("mac_address", MacAddress);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("os_distro_name", OsDistroName);
            writer.WriteStringValue("os_distro_revision", OsDistroRevision);
            writer.WriteStringValue("os_version", OsVersion);
            writer.WriteStringValue("os_version_extra", OsVersionExtra);
            writer.WriteDateTimeOffsetValue("revoked_at", RevokedAt);
            writer.WriteStringValue("serial_number", SerialNumber);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.TeamsDevices_user>("user", User);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
