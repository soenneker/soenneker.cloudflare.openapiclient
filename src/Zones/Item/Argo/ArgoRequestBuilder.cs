// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.Smart_routing;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.Tiered_caching;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\argo
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ArgoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The smart_routing property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.Smart_routing.Smart_routingRequestBuilder Smart_routing
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.Smart_routing.Smart_routingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tiered_caching property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.Tiered_caching.Tiered_cachingRequestBuilder Tiered_caching
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.Tiered_caching.Tiered_cachingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.ArgoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArgoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/argo", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Argo.ArgoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArgoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/argo", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
