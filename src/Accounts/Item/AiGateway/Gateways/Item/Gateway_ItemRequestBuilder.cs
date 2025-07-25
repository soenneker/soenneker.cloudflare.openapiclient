// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Datasets;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Evaluations;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Url;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\ai-gateway\gateways\{gateway_-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Gateway_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The datasets property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Datasets.DatasetsRequestBuilder Datasets
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Datasets.DatasetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The evaluations property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Evaluations.EvaluationsRequestBuilder Evaluations
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Evaluations.EvaluationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logs property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder Logs
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The url property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Url.UrlRequestBuilder Url
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Url.UrlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Gateway_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Gateway_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai-gateway/gateways/{gateway_%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Gateway_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Gateway_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai-gateway/gateways/{gateway_%2Did}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a Gateway
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_404">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_200?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_200> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_404.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetch a Gateway
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_404">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_200?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_200> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_404.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_fetch_gateway_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a Gateway
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_200"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_400">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_404">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_200?> PutAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_200> PutAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_400.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_404.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a Gateway
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
        /// Fetch a Gateway
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update a Gateway
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_update_gateway body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Gateway_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Gateway_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Gateway_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Gateway_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Gateway_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Gateway_ItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
