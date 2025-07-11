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
    public partial class Workers_binding_kind_workflow : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Class name of the Workflow. Should only be provided if the Workflow belongs to this script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClassName { get; set; }
#nullable restore
#else
        public string ClassName { get; set; }
#endif
        /// <summary>A JavaScript variable name for the binding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Script name that contains the Workflow. If not provided, defaults to this script name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScriptName { get; set; }
#nullable restore
#else
        public string ScriptName { get; set; }
#endif
        /// <summary>The kind of resource that the binding provides.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow_type? Type { get; set; }
        /// <summary>Name of the Workflow to bind to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkflowName { get; set; }
#nullable restore
#else
        public string WorkflowName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow"/> and sets the default values.
        /// </summary>
        public Workers_binding_kind_workflow()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "class_name", n => { ClassName = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "script_name", n => { ScriptName = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow_type>(); } },
                { "workflow_name", n => { WorkflowName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("class_name", ClassName);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("script_name", ScriptName);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_binding_kind_workflow_type>("type", Type);
            writer.WriteStringValue("workflow_name", WorkflowName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
