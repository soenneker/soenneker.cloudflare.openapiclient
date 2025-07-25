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
    public partial class Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Decreases the likelihood of the model repeating the same lines verbatim.</summary>
        public double? FrequencyPenalty { get; set; }
        /// <summary>Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Lora { get; set; }
#nullable restore
#else
        public string Lora { get; set; }
#endif
        /// <summary>The maximum number of tokens to generate in the response.</summary>
        public int? MaxTokens { get; set; }
        /// <summary>Increases the likelihood of the model introducing new topics.</summary>
        public double? PresencePenalty { get; set; }
        /// <summary>The input text prompt for the model to generate a response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Prompt { get; set; }
#nullable restore
#else
        public string Prompt { get; set; }
#endif
        /// <summary>If true, a chat template is not applied and you must adhere to the specific model&apos;s expected formatting.</summary>
        public bool? Raw { get; set; }
        /// <summary>Penalty for repeated tokens; higher values discourage repetition.</summary>
        public double? RepetitionPenalty { get; set; }
        /// <summary>The response_format property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1_response_format? ResponseFormat { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1_response_format ResponseFormat { get; set; }
#endif
        /// <summary>Random seed for reproducibility of the generation.</summary>
        public int? Seed { get; set; }
        /// <summary>If true, the response will be streamed back incrementally using SSE, Server Sent Events.</summary>
        public bool? Stream { get; set; }
        /// <summary>Controls the randomness of the output; higher values produce more random results.</summary>
        public double? Temperature { get; set; }
        /// <summary>Limits the AI to choose from the top &apos;k&apos; most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.</summary>
        public int? TopK { get; set; }
        /// <summary>Adjusts the creativity of the AI&apos;s responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.</summary>
        public double? TopP { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1"/> and sets the default values.
        /// </summary>
        public Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "frequency_penalty", n => { FrequencyPenalty = n.GetDoubleValue(); } },
                { "lora", n => { Lora = n.GetStringValue(); } },
                { "max_tokens", n => { MaxTokens = n.GetIntValue(); } },
                { "presence_penalty", n => { PresencePenalty = n.GetDoubleValue(); } },
                { "prompt", n => { Prompt = n.GetStringValue(); } },
                { "raw", n => { Raw = n.GetBoolValue(); } },
                { "repetition_penalty", n => { RepetitionPenalty = n.GetDoubleValue(); } },
                { "response_format", n => { ResponseFormat = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1_response_format>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1_response_format.CreateFromDiscriminatorValue); } },
                { "seed", n => { Seed = n.GetIntValue(); } },
                { "stream", n => { Stream = n.GetBoolValue(); } },
                { "temperature", n => { Temperature = n.GetDoubleValue(); } },
                { "top_k", n => { TopK = n.GetIntValue(); } },
                { "top_p", n => { TopP = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("frequency_penalty", FrequencyPenalty);
            writer.WriteStringValue("lora", Lora);
            writer.WriteIntValue("max_tokens", MaxTokens);
            writer.WriteDoubleValue("presence_penalty", PresencePenalty);
            writer.WriteStringValue("prompt", Prompt);
            writer.WriteBoolValue("raw", Raw);
            writer.WriteDoubleValue("repetition_penalty", RepetitionPenalty);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_hf_thebloke_llama_2_13b_chat_awqMember1_response_format>("response_format", ResponseFormat);
            writer.WriteIntValue("seed", Seed);
            writer.WriteBoolValue("stream", Stream);
            writer.WriteDoubleValue("temperature", Temperature);
            writer.WriteIntValue("top_k", TopK);
            writer.WriteDoubleValue("top_p", TopP);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
