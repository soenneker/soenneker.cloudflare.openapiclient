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
    public partial class Waitingroom_event_result : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_on property</summary>
        public DateTimeOffset? CreatedOn { get; private set; }
        /// <summary>If set, the event will override the waiting room&apos;s `custom_page_html` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomPageHtml { get; set; }
#nullable restore
#else
        public string CustomPageHtml { get; set; }
#endif
        /// <summary>A note that you can use to add more details about the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `disable_session_renewal` property while it is active. If null, the event will inherit it.</summary>
        public bool? DisableSessionRenewal { get; set; }
        /// <summary>An ISO 8601 timestamp that marks the end of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventEndTime { get; set; }
#nullable restore
#else
        public string EventEndTime { get; set; }
#endif
        /// <summary>An ISO 8601 timestamp that marks the start of the event. At this time, queued users will be processed with the event&apos;s configuration. The start time must be at least one minute before `event_end_time`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventStartTime { get; set; }
#nullable restore
#else
        public string EventStartTime { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The modified_on property</summary>
        public DateTimeOffset? ModifiedOn { get; private set; }
        /// <summary>A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `new_users_per_minute` property while it is active. If null, the event will inherit it. This can only be set if the event&apos;s `total_active_users` property is also set.</summary>
        public int? NewUsersPerMinute { get; set; }
        /// <summary>An ISO 8601 timestamp that marks when to begin queueing all users before the event starts. The prequeue must start at least five minutes before `event_start_time`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrequeueStartTime { get; set; }
#nullable restore
#else
        public string PrequeueStartTime { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `queueing_method` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueueingMethod { get; set; }
#nullable restore
#else
        public string QueueingMethod { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `session_duration` property while it is active. If null, the event will inherit it.</summary>
        public int? SessionDuration { get; set; }
        /// <summary>If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`. Requires that `prequeue_start_time` is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the `queueing_method` during the event respects ordering such as **fifo**, or else the shuffling may be unnecessary.</summary>
        public bool? ShuffleAtEventStart { get; set; }
        /// <summary>Suspends or allows an event. If set to `true`, the event is ignored and traffic will be handled based on the waiting room configuration.</summary>
        public bool? Suspended { get; set; }
        /// <summary>If set, the event will override the waiting room&apos;s `total_active_users` property while it is active. If null, the event will inherit it. This can only be set if the event&apos;s `new_users_per_minute` property is also set.</summary>
        public int? TotalActiveUsers { get; set; }
        /// <summary>If set, the event will override the waiting room&apos;s `turnstile_action` property while it is active. If null, the event will inherit it.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action? TurnstileAction { get; set; }
        /// <summary>If set, the event will override the waiting room&apos;s `turnstile_mode` property while it is active. If null, the event will inherit it.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode? TurnstileMode { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_result"/> and sets the default values.
        /// </summary>
        public Waitingroom_event_result()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_result"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_result CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_result();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
                { "custom_page_html", n => { CustomPageHtml = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "disable_session_renewal", n => { DisableSessionRenewal = n.GetBoolValue(); } },
                { "event_end_time", n => { EventEndTime = n.GetStringValue(); } },
                { "event_start_time", n => { EventStartTime = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "modified_on", n => { ModifiedOn = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "new_users_per_minute", n => { NewUsersPerMinute = n.GetIntValue(); } },
                { "prequeue_start_time", n => { PrequeueStartTime = n.GetStringValue(); } },
                { "queueing_method", n => { QueueingMethod = n.GetStringValue(); } },
                { "session_duration", n => { SessionDuration = n.GetIntValue(); } },
                { "shuffle_at_event_start", n => { ShuffleAtEventStart = n.GetBoolValue(); } },
                { "suspended", n => { Suspended = n.GetBoolValue(); } },
                { "total_active_users", n => { TotalActiveUsers = n.GetIntValue(); } },
                { "turnstile_action", n => { TurnstileAction = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action>(); } },
                { "turnstile_mode", n => { TurnstileMode = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("custom_page_html", CustomPageHtml);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("disable_session_renewal", DisableSessionRenewal);
            writer.WriteStringValue("event_end_time", EventEndTime);
            writer.WriteStringValue("event_start_time", EventStartTime);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("new_users_per_minute", NewUsersPerMinute);
            writer.WriteStringValue("prequeue_start_time", PrequeueStartTime);
            writer.WriteStringValue("queueing_method", QueueingMethod);
            writer.WriteIntValue("session_duration", SessionDuration);
            writer.WriteBoolValue("shuffle_at_event_start", ShuffleAtEventStart);
            writer.WriteBoolValue("suspended", Suspended);
            writer.WriteIntValue("total_active_users", TotalActiveUsers);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action>("turnstile_action", TurnstileAction);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode>("turnstile_mode", TurnstileMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
