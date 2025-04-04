// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Hijacks.Events;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Hijacks
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\bgp\hijacks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HijacksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The events property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Hijacks.Events.EventsRequestBuilder Events
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Hijacks.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Hijacks.HijacksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HijacksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bgp/hijacks", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Hijacks.HijacksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HijacksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bgp/hijacks", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
