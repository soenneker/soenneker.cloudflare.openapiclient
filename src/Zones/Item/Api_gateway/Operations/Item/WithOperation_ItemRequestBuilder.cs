// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.Schema_validation;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\api_gateway\operations\{operation_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithOperation_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The schema_validation property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.Schema_validation.Schema_validationRequestBuilder Schema_validation
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.Schema_validation.Schema_validationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOperation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/operations/{operation_id}{?feature*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOperation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/operations/{operation_id}{?feature*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an operation
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommon"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommon?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommon> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommon>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommon.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve information about an operation
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_singleOperationResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_singleOperationResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder.WithOperation_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_singleOperationResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder.WithOperation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_singleOperationResponse>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_singleOperationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an operation
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve information about an operation
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder.WithOperation_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder.WithOperation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithOperation_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve information about an operation
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithOperation_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Add feature(s) to the results. The feature name that is given here corresponds to the resulting feature object. Have a look at the top-level object description for more details on the specific meaning.</summary>
            [Obsolete("This property is deprecated, use FeatureAsGetFeatureQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("feature")]
            public string[]? Feature { get; set; }
#nullable restore
#else
            [QueryParameter("feature")]
            public string[] Feature { get; set; }
#endif
            /// <summary>Add feature(s) to the results. The feature name that is given here corresponds to the resulting feature object. Have a look at the top-level object description for more details on the specific meaning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("feature")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.GetFeatureQueryParameterType[]? FeatureAsGetFeatureQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("feature")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.GetFeatureQueryParameterType[] FeatureAsGetFeatureQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithOperation_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Operations.Item.WithOperation_ItemRequestBuilder.WithOperation_ItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
