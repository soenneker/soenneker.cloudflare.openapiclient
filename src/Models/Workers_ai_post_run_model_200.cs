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
    public partial class Workers_ai_post_run_model_200 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result? Result { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result Result { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200"/> and sets the default values.
        /// </summary>
        public Workers_ai_post_run_model_200()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "result", n => { Result = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="byte[]"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember2"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember3"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember6"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember7"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember8"/>, <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember9"/>, <see cref="string"/>, List&lt;global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1&gt;, List&lt;global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4&gt;, List&lt;global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Workers_ai_post_run_model_200_result : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="byte[]"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public byte[]? Binary { get; set; }
#nullable restore
#else
            public byte[] Binary { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1>? WorkersAiPostRunModel200ResultMember1 { get; set; }
#nullable restore
#else
            public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1> WorkersAiPostRunModel200ResultMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember2? WorkersAiPostRunModel200ResultMember2 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember2 WorkersAiPostRunModel200ResultMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember3"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember3? WorkersAiPostRunModel200ResultMember3 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember3 WorkersAiPostRunModel200ResultMember3 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4>? WorkersAiPostRunModel200ResultMember4 { get; set; }
#nullable restore
#else
            public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4> WorkersAiPostRunModel200ResultMember4 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5>? WorkersAiPostRunModel200ResultMember5 { get; set; }
#nullable restore
#else
            public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5> WorkersAiPostRunModel200ResultMember5 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember6"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember6? WorkersAiPostRunModel200ResultMember6 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember6 WorkersAiPostRunModel200ResultMember6 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember7"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember7? WorkersAiPostRunModel200ResultMember7 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember7 WorkersAiPostRunModel200ResultMember7 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember8"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember8? WorkersAiPostRunModel200ResultMember8 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember8 WorkersAiPostRunModel200ResultMember8 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember9"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember9? WorkersAiPostRunModel200ResultMember9 { get; set; }
#nullable restore
#else
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember9 WorkersAiPostRunModel200ResultMember9 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200.Workers_ai_post_run_model_200_result();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.WorkersAiPostRunModel200ResultMember2 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember2();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.WorkersAiPostRunModel200ResultMember3 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember3();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.WorkersAiPostRunModel200ResultMember6 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember6();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.WorkersAiPostRunModel200ResultMember7 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember7();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.WorkersAiPostRunModel200ResultMember8 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember8();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.WorkersAiPostRunModel200ResultMember9 = new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember9();
                }
                else if(parseNode.GetByteArrayValue() is byte[] binaryValue)
                {
                    result.Binary = binaryValue;
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1.CreateFromDiscriminatorValue)?.AsList() is List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1> workersAiPostRunModel200ResultMember1Value)
                {
                    result.WorkersAiPostRunModel200ResultMember1 = workersAiPostRunModel200ResultMember1Value;
                }
                else if(parseNode.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4.CreateFromDiscriminatorValue)?.AsList() is List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4> workersAiPostRunModel200ResultMember4Value)
                {
                    result.WorkersAiPostRunModel200ResultMember4 = workersAiPostRunModel200ResultMember4Value;
                }
                else if(parseNode.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5>(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5.CreateFromDiscriminatorValue)?.AsList() is List<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5> workersAiPostRunModel200ResultMember5Value)
                {
                    result.WorkersAiPostRunModel200ResultMember5 = workersAiPostRunModel200ResultMember5Value;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(WorkersAiPostRunModel200ResultMember2 != null)
                {
                    return WorkersAiPostRunModel200ResultMember2.GetFieldDeserializers();
                }
                else if(WorkersAiPostRunModel200ResultMember3 != null)
                {
                    return WorkersAiPostRunModel200ResultMember3.GetFieldDeserializers();
                }
                else if(WorkersAiPostRunModel200ResultMember6 != null)
                {
                    return WorkersAiPostRunModel200ResultMember6.GetFieldDeserializers();
                }
                else if(WorkersAiPostRunModel200ResultMember7 != null)
                {
                    return WorkersAiPostRunModel200ResultMember7.GetFieldDeserializers();
                }
                else if(WorkersAiPostRunModel200ResultMember8 != null)
                {
                    return WorkersAiPostRunModel200ResultMember8.GetFieldDeserializers();
                }
                else if(WorkersAiPostRunModel200ResultMember9 != null)
                {
                    return WorkersAiPostRunModel200ResultMember9.GetFieldDeserializers();
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
                if(WorkersAiPostRunModel200ResultMember2 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember2>(null, WorkersAiPostRunModel200ResultMember2);
                }
                else if(WorkersAiPostRunModel200ResultMember3 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember3>(null, WorkersAiPostRunModel200ResultMember3);
                }
                else if(WorkersAiPostRunModel200ResultMember6 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember6>(null, WorkersAiPostRunModel200ResultMember6);
                }
                else if(WorkersAiPostRunModel200ResultMember7 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember7>(null, WorkersAiPostRunModel200ResultMember7);
                }
                else if(WorkersAiPostRunModel200ResultMember8 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember8>(null, WorkersAiPostRunModel200ResultMember8);
                }
                else if(WorkersAiPostRunModel200ResultMember9 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember9>(null, WorkersAiPostRunModel200ResultMember9);
                }
                else if(Binary != null)
                {
                    writer.WriteByteArrayValue(null, Binary);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else if(WorkersAiPostRunModel200ResultMember1 != null)
                {
                    writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember1>(null, WorkersAiPostRunModel200ResultMember1);
                }
                else if(WorkersAiPostRunModel200ResultMember4 != null)
                {
                    writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember4>(null, WorkersAiPostRunModel200ResultMember4);
                }
                else if(WorkersAiPostRunModel200ResultMember5 != null)
                {
                    writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_model_200_resultMember5>(null, WorkersAiPostRunModel200ResultMember5);
                }
            }
        }
    }
}
#pragma warning restore CS0618
