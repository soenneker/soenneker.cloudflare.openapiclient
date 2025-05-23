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
    public partial class Aaa_auditLogs : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_action? Action { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_action Action { get; set; }
#endif
        /// <summary>The actor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_actor? Actor { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_actor Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A string that uniquely identifies the audit log.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The source of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Interface { get; set; }
#nullable restore
#else
        public string Interface { get; set; }
#endif
        /// <summary>An object which can lend more context to the action being logged. This is a flexible value and varies between different actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_metadata Metadata { get; set; }
#endif
        /// <summary>The new value of the resource that was modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewValue { get; set; }
#nullable restore
#else
        public string NewValue { get; set; }
#endif
        /// <summary>The value of the resource before it was modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldValue { get; set; }
#nullable restore
#else
        public string OldValue { get; set; }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_owner? Owner { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_owner Owner { get; set; }
#endif
        /// <summary>The resource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_resource? Resource { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_resource Resource { get; set; }
#endif
        /// <summary>A UTC RFC3339 timestamp that specifies when the action being logged occured.</summary>
        public DateTimeOffset? When { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs"/> and sets the default values.
        /// </summary>
        public Aaa_auditLogs()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_action>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_action.CreateFromDiscriminatorValue); } },
                { "actor", n => { Actor = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_actor>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_actor.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "interface", n => { Interface = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_metadata>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_metadata.CreateFromDiscriminatorValue); } },
                { "newValue", n => { NewValue = n.GetStringValue(); } },
                { "oldValue", n => { OldValue = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_owner>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_owner.CreateFromDiscriminatorValue); } },
                { "resource", n => { Resource = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_resource>(global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_resource.CreateFromDiscriminatorValue); } },
                { "when", n => { When = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_action>("action", Action);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_actor>("actor", Actor);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("interface", Interface);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_metadata>("metadata", Metadata);
            writer.WriteStringValue("newValue", NewValue);
            writer.WriteStringValue("oldValue", OldValue);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_owner>("owner", Owner);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Aaa_auditLogs_resource>("resource", Resource);
            writer.WriteDateTimeOffsetValue("when", When);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
