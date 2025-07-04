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
    /// A read-only field that shows which unauthorized settings are currently active on the zone. These settings typically result from upgrades or downgrades.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BotManagement_bot_fight_mode_config_stale_zone_configuration : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates that the zone&apos;s wordpress optimization for SBFM is turned on.</summary>
        public bool? OptimizeWordpress { get; set; }
        /// <summary>Indicates that the zone&apos;s definitely automated requests are being blocked or challenged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SbfmDefinitelyAutomated { get; set; }
#nullable restore
#else
        public string SbfmDefinitelyAutomated { get; set; }
#endif
        /// <summary>Indicates that the zone&apos;s likely automated requests are being blocked or challenged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SbfmLikelyAutomated { get; set; }
#nullable restore
#else
        public string SbfmLikelyAutomated { get; set; }
#endif
        /// <summary>Indicates that the zone&apos;s static resource protection is turned on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SbfmStaticResourceProtection { get; set; }
#nullable restore
#else
        public string SbfmStaticResourceProtection { get; set; }
#endif
        /// <summary>Indicates that the zone&apos;s verified bot requests are being blocked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SbfmVerifiedBots { get; set; }
#nullable restore
#else
        public string SbfmVerifiedBots { get; set; }
#endif
        /// <summary>Indicates that the zone&apos;s session score tracking is disabled.</summary>
        public bool? SuppressSessionScore { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.BotManagement_bot_fight_mode_config_stale_zone_configuration"/> and sets the default values.
        /// </summary>
        public BotManagement_bot_fight_mode_config_stale_zone_configuration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.BotManagement_bot_fight_mode_config_stale_zone_configuration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.BotManagement_bot_fight_mode_config_stale_zone_configuration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.BotManagement_bot_fight_mode_config_stale_zone_configuration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "optimize_wordpress", n => { OptimizeWordpress = n.GetBoolValue(); } },
                { "sbfm_definitely_automated", n => { SbfmDefinitelyAutomated = n.GetStringValue(); } },
                { "sbfm_likely_automated", n => { SbfmLikelyAutomated = n.GetStringValue(); } },
                { "sbfm_static_resource_protection", n => { SbfmStaticResourceProtection = n.GetStringValue(); } },
                { "sbfm_verified_bots", n => { SbfmVerifiedBots = n.GetStringValue(); } },
                { "suppress_session_score", n => { SuppressSessionScore = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("optimize_wordpress", OptimizeWordpress);
            writer.WriteStringValue("sbfm_definitely_automated", SbfmDefinitelyAutomated);
            writer.WriteStringValue("sbfm_likely_automated", SbfmLikelyAutomated);
            writer.WriteStringValue("sbfm_static_resource_protection", SbfmStaticResourceProtection);
            writer.WriteStringValue("sbfm_verified_bots", SbfmVerifiedBots);
            writer.WriteBoolValue("suppress_session_score", SuppressSessionScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
