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
    public partial class Cloudflare_d1_import_databaseMember3 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates you&apos;ve finished uploading to tell the D1 to start consuming it</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3_action? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>This identifies the currently-running import, checking its status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentBookmark { get; set; }
#nullable restore
#else
        public string CurrentBookmark { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3"/> and sets the default values.
        /// </summary>
        public Cloudflare_d1_import_databaseMember3()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3_action>(); } },
                { "current_bookmark", n => { CurrentBookmark = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_d1_import_databaseMember3_action>("action", Action);
            writer.WriteStringValue("current_bookmark", CurrentBookmark);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
