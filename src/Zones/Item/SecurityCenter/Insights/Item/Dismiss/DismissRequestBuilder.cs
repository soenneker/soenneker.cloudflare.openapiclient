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
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.SecurityCenter.Insights.Item.Dismiss
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\security-center\insights\{issue_id}\dismiss
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DismissRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.SecurityCenter.Insights.Item.Dismiss.DismissRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DismissRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/security-center/insights/{issue_id}/dismiss", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.SecurityCenter.Insights.Item.Dismiss.DismissRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DismissRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/security-center/insights/{issue_id}/dismiss", rawUrl)
        {
        }
        /// <summary>
        /// Archive Zone Security Center Insight
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight_200"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.SecurityCenter_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight_200?> PutAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight_200> PutAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.SecurityCenter_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Archive Zone Security Center Insight
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Archive_zone_security_center_insight body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.SecurityCenter.Insights.Item.Dismiss.DismissRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.SecurityCenter.Insights.Item.Dismiss.DismissRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.SecurityCenter.Insights.Item.Dismiss.DismissRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DismissRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
