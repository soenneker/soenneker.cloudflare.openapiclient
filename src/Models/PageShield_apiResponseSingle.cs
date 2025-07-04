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
    public partial class PageShield_apiResponseSingle : global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseCommon, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result? Result { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result Result { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "result", n => { Result = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result>(global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result>("result", Result);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember1"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember2"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PageShield_apiResponseSingle_result : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember1? PageShieldApiResponseSingleResultMember1 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember1 PageShieldApiResponseSingleResultMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember2? PageShieldApiResponseSingleResultMember2 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember2 PageShieldApiResponseSingleResultMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle.PageShield_apiResponseSingle_result();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.PageShieldApiResponseSingleResultMember1 = new global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember1();
                    result.PageShieldApiResponseSingleResultMember2 = new global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember2();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(PageShieldApiResponseSingleResultMember1 != null || PageShieldApiResponseSingleResultMember2 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(PageShieldApiResponseSingleResultMember1, PageShieldApiResponseSingleResultMember2);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.PageShield_apiResponseSingle_resultMember1>(null, PageShieldApiResponseSingleResultMember1, PageShieldApiResponseSingleResultMember2);
                }
            }
        }
    }
}
#pragma warning restore CS0618
