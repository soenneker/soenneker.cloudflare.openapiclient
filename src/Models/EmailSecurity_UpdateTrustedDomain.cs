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
    public partial class EmailSecurity_UpdateTrustedDomain : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The comments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comments { get; set; }
#nullable restore
#else
        public string Comments { get; set; }
#endif
        /// <summary>Select to prevent recently registered domains from triggering aSuspicious or Malicious disposition.</summary>
        public bool? IsRecent { get; set; }
        /// <summary>The is_regex property</summary>
        public bool? IsRegex { get; set; }
        /// <summary>Select for partner or other approved domains that have similarspelling to your connected domains. Prevents listed domains fromtriggering a Spoof disposition.</summary>
        public bool? IsSimilarity { get; set; }
        /// <summary>The pattern property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pattern { get; set; }
#nullable restore
#else
        public string Pattern { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.EmailSecurity_UpdateTrustedDomain"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.EmailSecurity_UpdateTrustedDomain CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.EmailSecurity_UpdateTrustedDomain();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comments", n => { Comments = n.GetStringValue(); } },
                { "is_recent", n => { IsRecent = n.GetBoolValue(); } },
                { "is_regex", n => { IsRegex = n.GetBoolValue(); } },
                { "is_similarity", n => { IsSimilarity = n.GetBoolValue(); } },
                { "pattern", n => { Pattern = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comments", Comments);
            writer.WriteBoolValue("is_recent", IsRecent);
            writer.WriteBoolValue("is_regex", IsRegex);
            writer.WriteBoolValue("is_similarity", IsSimilarity);
            writer.WriteStringValue("pattern", Pattern);
        }
    }
}
#pragma warning restore CS0618
