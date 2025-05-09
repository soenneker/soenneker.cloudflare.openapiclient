// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.Summary;
using Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.Timeseries_groups;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\quality\iqi
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IqiRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The summary property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.Summary.SummaryRequestBuilder Summary
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.Summary.SummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeseries_groups property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.Timeseries_groups.Timeseries_groupsRequestBuilder Timeseries_groups
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.Timeseries_groups.Timeseries_groupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.IqiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IqiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/quality/iqi", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Quality.Iqi.IqiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IqiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/quality/iqi", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
