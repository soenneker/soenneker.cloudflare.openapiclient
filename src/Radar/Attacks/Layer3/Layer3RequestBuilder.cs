// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Summary;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Timeseries;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Timeseries_groups;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\attacks\layer3
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Layer3RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The summary property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Summary.SummaryRequestBuilder Summary
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Summary.SummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeseries property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Timeseries.TimeseriesRequestBuilder Timeseries
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Timeseries.TimeseriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeseries_groups property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Timeseries_groups.Timeseries_groupsRequestBuilder Timeseries_groups
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Timeseries_groups.Timeseries_groupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The top property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.TopRequestBuilder Top
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.TopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Layer3RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Layer3RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/attacks/layer3", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Layer3RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Layer3RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/attacks/layer3", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
