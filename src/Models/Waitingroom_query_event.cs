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
    public partial class Waitingroom_query_event : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set, the event will override the waiting room&apos;s `custom_page_html` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_custom_page_html? CustomPageHtml { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_custom_page_html CustomPageHtml { get; set; }
#endif
        /// <summary>A note that you can use to add more details about the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_description? Description { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_description Description { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `disable_session_renewal` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_disable_session_renewal? DisableSessionRenewal { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_disable_session_renewal DisableSessionRenewal { get; set; }
#endif
        /// <summary>An ISO 8601 timestamp that marks the end of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_end_time? EventEndTime { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_end_time EventEndTime { get; set; }
#endif
        /// <summary>An ISO 8601 timestamp that marks the start of the event. At this time, queued users will be processed with the event&apos;s configuration. The start time must be at least one minute before `event_end_time`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_start_time? EventStartTime { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_start_time EventStartTime { get; set; }
#endif
        /// <summary>A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_name? Name { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_name Name { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `new_users_per_minute` property while it is active. If null, the event will inherit it. This can only be set if the event&apos;s `total_active_users` property is also set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_new_users_per_minute? NewUsersPerMinute { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_new_users_per_minute NewUsersPerMinute { get; set; }
#endif
        /// <summary>An ISO 8601 timestamp that marks when to begin queueing all users before the event starts. The prequeue must start at least five minutes before `event_start_time`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_prequeue_start_time? PrequeueStartTime { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_prequeue_start_time PrequeueStartTime { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `queueing_method` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_queueing_method? QueueingMethod { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_queueing_method QueueingMethod { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `session_duration` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_session_duration? SessionDuration { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_session_duration SessionDuration { get; set; }
#endif
        /// <summary>If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`. Requires that `prequeue_start_time` is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the `queueing_method` during the event respects ordering such as **fifo**, or else the shuffling may be unnecessary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_shuffle_at_event_start? ShuffleAtEventStart { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_shuffle_at_event_start ShuffleAtEventStart { get; set; }
#endif
        /// <summary>Suspends or allows an event. If set to `true`, the event is ignored and traffic will be handled based on the waiting room configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_suspended? Suspended { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_suspended Suspended { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `total_active_users` property while it is active. If null, the event will inherit it. This can only be set if the event&apos;s `new_users_per_minute` property is also set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_total_active_users? TotalActiveUsers { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_total_active_users TotalActiveUsers { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `turnstile_action` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action? TurnstileAction { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action TurnstileAction { get; set; }
#endif
        /// <summary>If set, the event will override the waiting room&apos;s `turnstile_mode` property while it is active. If null, the event will inherit it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode? TurnstileMode { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode TurnstileMode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_query_event"/> and sets the default values.
        /// </summary>
        public Waitingroom_query_event()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_query_event"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_query_event CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_query_event();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "custom_page_html", n => { CustomPageHtml = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_custom_page_html>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_custom_page_html.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_description>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_description.CreateFromDiscriminatorValue); } },
                { "disable_session_renewal", n => { DisableSessionRenewal = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_disable_session_renewal>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_disable_session_renewal.CreateFromDiscriminatorValue); } },
                { "event_end_time", n => { EventEndTime = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_end_time>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_end_time.CreateFromDiscriminatorValue); } },
                { "event_start_time", n => { EventStartTime = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_start_time>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_start_time.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_name>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_name.CreateFromDiscriminatorValue); } },
                { "new_users_per_minute", n => { NewUsersPerMinute = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_new_users_per_minute>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_new_users_per_minute.CreateFromDiscriminatorValue); } },
                { "prequeue_start_time", n => { PrequeueStartTime = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_prequeue_start_time>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_prequeue_start_time.CreateFromDiscriminatorValue); } },
                { "queueing_method", n => { QueueingMethod = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_queueing_method>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_queueing_method.CreateFromDiscriminatorValue); } },
                { "session_duration", n => { SessionDuration = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_session_duration>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_session_duration.CreateFromDiscriminatorValue); } },
                { "shuffle_at_event_start", n => { ShuffleAtEventStart = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_shuffle_at_event_start>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_shuffle_at_event_start.CreateFromDiscriminatorValue); } },
                { "suspended", n => { Suspended = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_suspended>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_suspended.CreateFromDiscriminatorValue); } },
                { "total_active_users", n => { TotalActiveUsers = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_total_active_users>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_total_active_users.CreateFromDiscriminatorValue); } },
                { "turnstile_action", n => { TurnstileAction = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action.CreateFromDiscriminatorValue); } },
                { "turnstile_mode", n => { TurnstileMode = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode>(global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_custom_page_html>("custom_page_html", CustomPageHtml);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_description>("description", Description);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_disable_session_renewal>("disable_session_renewal", DisableSessionRenewal);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_end_time>("event_end_time", EventEndTime);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_start_time>("event_start_time", EventStartTime);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_name>("name", Name);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_new_users_per_minute>("new_users_per_minute", NewUsersPerMinute);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_prequeue_start_time>("prequeue_start_time", PrequeueStartTime);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_queueing_method>("queueing_method", QueueingMethod);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_session_duration>("session_duration", SessionDuration);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_shuffle_at_event_start>("shuffle_at_event_start", ShuffleAtEventStart);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_suspended>("suspended", Suspended);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_total_active_users>("total_active_users", TotalActiveUsers);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_action>("turnstile_action", TurnstileAction);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Waitingroom_event_turnstile_mode>("turnstile_mode", TurnstileMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
