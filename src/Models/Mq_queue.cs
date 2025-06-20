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
    public partial class Mq_queue : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The consumers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_consumer>? Consumers { get; private set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_consumer> Consumers { get; private set; }
#endif
        /// <summary>The consumers_total_count property</summary>
        public double? ConsumersTotalCount { get; private set; }
        /// <summary>The created_on property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedOn { get; private set; }
#nullable restore
#else
        public string CreatedOn { get; private set; }
#endif
        /// <summary>The modified_on property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifiedOn { get; private set; }
#nullable restore
#else
        public string ModifiedOn { get; private set; }
#endif
        /// <summary>The producers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_producer>? Producers { get; private set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_producer> Producers { get; private set; }
#endif
        /// <summary>The producers_total_count property</summary>
        public double? ProducersTotalCount { get; private set; }
        /// <summary>The queue_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueueId { get; private set; }
#nullable restore
#else
        public string QueueId { get; private set; }
#endif
        /// <summary>The queue_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueueName { get; set; }
#nullable restore
#else
        public string QueueName { get; set; }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queueSettings? Settings { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queueSettings Settings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queue"/> and sets the default values.
        /// </summary>
        public Mq_queue()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "consumers", n => { Consumers = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_consumer>(global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_consumer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "consumers_total_count", n => { ConsumersTotalCount = n.GetDoubleValue(); } },
                { "created_on", n => { CreatedOn = n.GetStringValue(); } },
                { "modified_on", n => { ModifiedOn = n.GetStringValue(); } },
                { "producers", n => { Producers = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_producer>(global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_producer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "producers_total_count", n => { ProducersTotalCount = n.GetDoubleValue(); } },
                { "queue_id", n => { QueueId = n.GetStringValue(); } },
                { "queue_name", n => { QueueName = n.GetStringValue(); } },
                { "settings", n => { Settings = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queueSettings>(global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queueSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("queue_name", QueueName);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_queueSettings>("settings", Settings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
