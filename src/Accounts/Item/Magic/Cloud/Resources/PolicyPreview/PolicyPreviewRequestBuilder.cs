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
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Resources.PolicyPreview
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\magic\cloud\resources\policy-preview
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PolicyPreviewRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Resources.PolicyPreview.PolicyPreviewRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PolicyPreviewRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/magic/cloud/resources/policy-preview", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Resources.PolicyPreview.PolicyPreviewRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PolicyPreviewRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/magic/cloud/resources/policy-preview", rawUrl)
        {
        }
        /// <summary>
        /// Preview Rego query result against the latest resource catalog (Closed Beta).
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_response?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_response> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_response>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Preview Rego query result against the latest resource catalog (Closed Beta).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_resources_catalog_policy_preview_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Resources.PolicyPreview.PolicyPreviewRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Resources.PolicyPreview.PolicyPreviewRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Resources.PolicyPreview.PolicyPreviewRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PolicyPreviewRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
