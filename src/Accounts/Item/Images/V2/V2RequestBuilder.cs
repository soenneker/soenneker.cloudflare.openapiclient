// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.Direct_upload;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\images\v2
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class V2RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The direct_upload property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.Direct_upload.Direct_uploadRequestBuilder Direct_upload
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.Direct_upload.Direct_uploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/images/v2{?continuation_token*,creator*,per_page*,sort_order*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/images/v2{?continuation_token*,creator*,per_page*,sort_order*}", rawUrl)
        {
        }
        /// <summary>
        /// List up to 10000 images with one request. Use the optional parameters below to get a specific range of images.Endpoint returns continuation_token if more images are present.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Images_images_list_response_v2"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_images_list_images_v2_4XX">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Images_images_list_response_v2?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder.V2RequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Images_images_list_response_v2> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder.V2RequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Cloudflare_images_list_images_v2_4XX.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Images_images_list_response_v2>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Images_images_list_response_v2.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List up to 10000 images with one request. Use the optional parameters below to get a specific range of images.Endpoint returns continuation_token if more images are present.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder.V2RequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder.V2RequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List up to 10000 images with one request. Use the optional parameters below to get a specific range of images.Endpoint returns continuation_token if more images are present.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class V2RequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("continuation_token")]
            public string? ContinuationToken { get; set; }
#nullable restore
#else
            [QueryParameter("continuation_token")]
            public string ContinuationToken { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("creator")]
            public string? Creator { get; set; }
#nullable restore
#else
            [QueryParameter("creator")]
            public string Creator { get; set; }
#endif
            [QueryParameter("per_page")]
            public double? PerPage { get; set; }
            [Obsolete("This property is deprecated, use SortOrderAsGetSortOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort_order")]
            public string? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sort_order")]
            public string SortOrder { get; set; }
#endif
            [QueryParameter("sort_order")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.GetSort_orderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class V2RequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Images.V2.V2RequestBuilder.V2RequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
