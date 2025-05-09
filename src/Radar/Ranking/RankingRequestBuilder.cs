// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Domain;
using Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Internet_services;
using Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Timeseries_groups;
using Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Top;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Ranking
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\ranking
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RankingRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The domain property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Domain.DomainRequestBuilder Domain
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Domain.DomainRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The internet_services property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Internet_services.Internet_servicesRequestBuilder Internet_services
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Internet_services.Internet_servicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeseries_groups property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Timeseries_groups.Timeseries_groupsRequestBuilder Timeseries_groups
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Timeseries_groups.Timeseries_groupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The top property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Top.TopRequestBuilder Top
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.Top.TopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.RankingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RankingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/ranking", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Ranking.RankingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RankingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/ranking", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
