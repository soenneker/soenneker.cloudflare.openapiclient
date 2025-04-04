// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Attacks;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Industry;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Locations;
using Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Vertical;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\attacks\layer3\top
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TopRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The attacks property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Attacks.AttacksRequestBuilder Attacks
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Attacks.AttacksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The industry property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Industry.IndustryRequestBuilder Industry
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Industry.IndustryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The locations property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Locations.LocationsRequestBuilder Locations
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Locations.LocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The vertical property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Vertical.VerticalRequestBuilder Vertical
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.Vertical.VerticalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.TopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TopRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/attacks/layer3/top", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Attacks.Layer3.Top.TopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TopRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/attacks/layer3/top", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
