// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\api_gateway\discovery\operations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OperationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.zones.item.api_gateway.discovery.operations.item collection</summary>
        /// <param name="position">Identifier for the discovered operation</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.Item.WithOperation_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.Item.WithOperation_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("operation_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.Item.WithOperation_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OperationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/discovery/operations{?diff*,direction*,endpoint*,host*,method*,order*,origin*,page*,per_page*,state*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OperationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/discovery/operations{?diff*,direction*,endpoint*,host*,method*,order*,origin*,page*,per_page*,state*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the most up to date view of discovered operations
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_4XX">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_200?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder.OperationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_200> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder.OperationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_4XX.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_api_discovery_retrieve_discovered_operations_on_a_zone_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the `state` on one or more discovered operations
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_patch_discoveries_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_patch_discoveries_response?> PatchAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_api_discovery_patch_multiple_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_patch_discoveries_response> PatchAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_api_discovery_patch_multiple_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_patch_discoveries_response>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_patch_discoveries_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the most up to date view of discovered operations
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder.OperationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder.OperationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the `state` on one or more discovered operations
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_api_discovery_patch_multiple_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_api_discovery_patch_multiple_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the most up to date view of discovered operations
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OperationsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("diff")]
            public bool? Diff { get; set; }
            [Obsolete("This property is deprecated, use DirectionAsGetDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("direction")]
            public string? Direction { get; set; }
#nullable restore
#else
            [QueryParameter("direction")]
            public string Direction { get; set; }
#endif
            [QueryParameter("direction")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("endpoint")]
            public string? Endpoint { get; set; }
#nullable restore
#else
            [QueryParameter("endpoint")]
            public string Endpoint { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("host")]
            public string[]? Host { get; set; }
#nullable restore
#else
            [QueryParameter("host")]
            public string[] Host { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("method")]
            public string[]? Method { get; set; }
#nullable restore
#else
            [QueryParameter("method")]
            public string[] Method { get; set; }
#endif
            [Obsolete("This property is deprecated, use OrderAsGetOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order")]
            public string? Order { get; set; }
#nullable restore
#else
            [QueryParameter("order")]
            public string Order { get; set; }
#endif
            [QueryParameter("order")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.GetOrderQueryParameterType? OrderAsGetOrderQueryParameterType { get; set; }
            /// <summary>Filter results to only include discovery results sourced from a particular discovery engine  * `ML` - Discovered operations that were sourced using ML API Discovery  * `SessionIdentifier` - Discovered operations that were sourced using Session Identifier API Discovery</summary>
            [Obsolete("This property is deprecated, use OriginAsApiShieldApiDiscoveryOrigin instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("origin")]
            public string? Origin { get; set; }
#nullable restore
#else
            [QueryParameter("origin")]
            public string Origin { get; set; }
#endif
            /// <summary>Filter results to only include discovery results sourced from a particular discovery engine  * `ML` - Discovered operations that were sourced using ML API Discovery  * `SessionIdentifier` - Discovered operations that were sourced using Session Identifier API Discovery</summary>
            [QueryParameter("origin")]
            public global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_api_discovery_origin? OriginAsApiShieldApiDiscoveryOrigin { get; set; }
            /// <summary>Page number of paginated results.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>Maximum number of results per page.</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Filter results to only include discovery results in a particular state. States are as follows  * `review` - Discovered operations that are not saved into API Shield Endpoint Management  * `saved` - Discovered operations that are already saved into API Shield Endpoint Management  * `ignored` - Discovered operations that have been marked as ignored</summary>
            [Obsolete("This property is deprecated, use StateAsApiShieldApiDiscoveryState instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("state")]
            public string? State { get; set; }
#nullable restore
#else
            [QueryParameter("state")]
            public string State { get; set; }
#endif
            /// <summary>Filter results to only include discovery results in a particular state. States are as follows  * `review` - Discovered operations that are not saved into API Shield Endpoint Management  * `saved` - Discovered operations that are already saved into API Shield Endpoint Management  * `ignored` - Discovered operations that have been marked as ignored</summary>
            [QueryParameter("state")]
            public global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_api_discovery_state? StateAsApiShieldApiDiscoveryState { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OperationsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Discovery.Operations.OperationsRequestBuilder.OperationsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OperationsRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
