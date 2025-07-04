// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.Summary;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.Timeseries_groups;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\bots\crawlers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CrawlersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The summary property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.Summary.SummaryRequestBuilder Summary
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.Summary.SummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeseries_groups property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.Timeseries_groups.Timeseries_groupsRequestBuilder Timeseries_groups
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.Timeseries_groups.Timeseries_groupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.CrawlersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CrawlersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bots/crawlers", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bots.Crawlers.CrawlersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CrawlersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bots/crawlers", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
