// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.Model;
using Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.TaskNamespace;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\ai\inference\timeseries_groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Timeseries_groupsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The model property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.Model.ModelRequestBuilder Model
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.Model.ModelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The task property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.TaskNamespace.TaskRequestBuilder Task
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.TaskNamespace.TaskRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.Timeseries_groupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Timeseries_groupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/ai/inference/timeseries_groups", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Ai.Inference.Timeseries_groups.Timeseries_groupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Timeseries_groupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/ai/inference/timeseries_groups", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
