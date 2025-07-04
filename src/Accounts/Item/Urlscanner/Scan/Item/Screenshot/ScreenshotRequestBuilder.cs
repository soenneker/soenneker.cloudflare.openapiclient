// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\urlscanner\scan\{scan_id}\screenshot
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScreenshotRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScreenshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/urlscanner/scan/{scan_id}/screenshot{?resolution*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScreenshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/urlscanner/scan/{scan_id}/screenshot{?resolution*}", rawUrl)
        {
        }
        /// <summary>
        /// Get scan&apos;s screenshot by resolution (desktop/mobile/tablet).
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_202"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_400">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_404">When receiving a 404 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_202?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder.ScreenshotRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_202> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder.ScreenshotRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_400.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_404.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_202>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Urlscanner_get_scan_screenshot_202.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get scan&apos;s screenshot by resolution (desktop/mobile/tablet).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder.ScreenshotRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder.ScreenshotRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get scan&apos;s screenshot by resolution (desktop/mobile/tablet).
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScreenshotRequestBuilderGetQueryParameters 
        {
            /// <summary>Target device type.</summary>
            [Obsolete("This property is deprecated, use ResolutionAsGetResolutionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("resolution")]
            public string? Resolution { get; set; }
#nullable restore
#else
            [QueryParameter("resolution")]
            public string Resolution { get; set; }
#endif
            /// <summary>Target device type.</summary>
            [QueryParameter("resolution")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.GetResolutionQueryParameterType? ResolutionAsGetResolutionQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScreenshotRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Urlscanner.Scan.Item.Screenshot.ScreenshotRequestBuilder.ScreenshotRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
