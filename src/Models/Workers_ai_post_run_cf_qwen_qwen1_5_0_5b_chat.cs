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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember1"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember2"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chat : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember1? WorkersAiPostRunCfQwenQwen1505bChatMember1 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember1 WorkersAiPostRunCfQwenQwen1505bChatMember1 { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember2? WorkersAiPostRunCfQwenQwen1505bChatMember2 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember2 WorkersAiPostRunCfQwenQwen1505bChatMember2 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chat();
            if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WorkersAiPostRunCfQwenQwen1505bChatMember1 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember1();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WorkersAiPostRunCfQwenQwen1505bChatMember2 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember2();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(WorkersAiPostRunCfQwenQwen1505bChatMember1 != null)
            {
                return WorkersAiPostRunCfQwenQwen1505bChatMember1.GetFieldDeserializers();
            }
            else if(WorkersAiPostRunCfQwenQwen1505bChatMember2 != null)
            {
                return WorkersAiPostRunCfQwenQwen1505bChatMember2.GetFieldDeserializers();
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
            if(WorkersAiPostRunCfQwenQwen1505bChatMember1 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember1>(null, WorkersAiPostRunCfQwenQwen1505bChatMember1);
            }
            else if(WorkersAiPostRunCfQwenQwen1505bChatMember2 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_qwen_qwen1_5_0_5b_chatMember2>(null, WorkersAiPostRunCfQwenQwen1505bChatMember2);
            }
        }
    }
}
#pragma warning restore CS0618
