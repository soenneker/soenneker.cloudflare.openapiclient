// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Ases;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Moas;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Pfx2as;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Realtime;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Stats;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\bgp\routes
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RoutesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ases property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Ases.AsesRequestBuilder Ases
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Ases.AsesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The moas property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Moas.MoasRequestBuilder Moas
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Moas.MoasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pfx2as property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Pfx2as.Pfx2asRequestBuilder Pfx2as
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Pfx2as.Pfx2asRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The realtime property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Realtime.RealtimeRequestBuilder Realtime
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Realtime.RealtimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stats property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Stats.StatsRequestBuilder Stats
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.Stats.StatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.RoutesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoutesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bgp/routes", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Routes.RoutesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoutesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bgp/routes", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
