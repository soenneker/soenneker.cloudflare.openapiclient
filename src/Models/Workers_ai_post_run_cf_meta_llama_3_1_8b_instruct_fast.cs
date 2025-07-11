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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember1"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember2"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fast : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember1? WorkersAiPostRunCfMetaLlama318bInstructFastMember1 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember1 WorkersAiPostRunCfMetaLlama318bInstructFastMember1 { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember2? WorkersAiPostRunCfMetaLlama318bInstructFastMember2 { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember2 WorkersAiPostRunCfMetaLlama318bInstructFastMember2 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fast"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fast CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fast();
            if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WorkersAiPostRunCfMetaLlama318bInstructFastMember1 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember1();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.WorkersAiPostRunCfMetaLlama318bInstructFastMember2 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember2();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(WorkersAiPostRunCfMetaLlama318bInstructFastMember1 != null)
            {
                return WorkersAiPostRunCfMetaLlama318bInstructFastMember1.GetFieldDeserializers();
            }
            else if(WorkersAiPostRunCfMetaLlama318bInstructFastMember2 != null)
            {
                return WorkersAiPostRunCfMetaLlama318bInstructFastMember2.GetFieldDeserializers();
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
            if(WorkersAiPostRunCfMetaLlama318bInstructFastMember1 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember1>(null, WorkersAiPostRunCfMetaLlama318bInstructFastMember1);
            }
            else if(WorkersAiPostRunCfMetaLlama318bInstructFastMember2 != null)
            {
                writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_llama_3_1_8b_instruct_fastMember2>(null, WorkersAiPostRunCfMetaLlama318bInstructFastMember2);
            }
        }
    }
}
#pragma warning restore CS0618
