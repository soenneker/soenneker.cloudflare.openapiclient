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
    public partial class Workers_ai_post_run_cf_openai_whisper_large_v3_turbo_200_result_transcription_info : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total duration of the original audio file, in seconds.</summary>
        public double? Duration { get; set; }
        /// <summary>The duration of the audio after applying Voice Activity Detection (VAD) to remove silent or irrelevant sections, in seconds.</summary>
        public double? DurationAfterVad { get; set; }
        /// <summary>The language of the audio being transcribed or translated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The confidence level or probability of the detected language being accurate, represented as a decimal between 0 and 1.</summary>
        public double? LanguageProbability { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_openai_whisper_large_v3_turbo_200_result_transcription_info"/> and sets the default values.
        /// </summary>
        public Workers_ai_post_run_cf_openai_whisper_large_v3_turbo_200_result_transcription_info()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_openai_whisper_large_v3_turbo_200_result_transcription_info"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_openai_whisper_large_v3_turbo_200_result_transcription_info CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_openai_whisper_large_v3_turbo_200_result_transcription_info();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "duration", n => { Duration = n.GetDoubleValue(); } },
                { "duration_after_vad", n => { DurationAfterVad = n.GetDoubleValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "language_probability", n => { LanguageProbability = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("duration", Duration);
            writer.WriteDoubleValue("duration_after_vad", DurationAfterVad);
            writer.WriteStringValue("language", Language);
            writer.WriteDoubleValue("language_probability", LanguageProbability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
