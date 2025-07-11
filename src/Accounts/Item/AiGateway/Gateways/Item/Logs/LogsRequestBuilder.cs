// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.Item;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\ai-gateway\gateways\{gateway_-id}\logs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LogsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.accounts.item.aiGateway.gateways.item.logs.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.Item.LogsItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.Item.LogsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.Item.LogsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LogsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai-gateway/gateways/{gateway_%2Did}/logs{?cached*,direction*,end_date*,feedback*,filters*,limit*,max_cost*,max_duration*,max_tokens_in*,max_tokens_out*,max_total_tokens*,meta_info*,min_cost*,min_duration*,min_tokens_in*,min_tokens_out*,min_total_tokens*,model*,model_type*,order_by*,order_by_direction*,page*,per_page*,provider*,request_content_type*,response_content_type*,search*,start_date*,success*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LogsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai-gateway/gateways/{gateway_%2Did}/logs{?cached*,direction*,end_date*,feedback*,filters*,limit*,max_cost*,max_duration*,max_tokens_in*,max_tokens_out*,max_total_tokens*,meta_info*,min_cost*,min_duration*,min_tokens_in*,min_tokens_out*,min_total_tokens*,model*,model_type*,order_by*,order_by_direction*,page*,per_page*,provider*,request_content_type*,response_content_type*,search*,start_date*,success*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete Gateway Logs
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_400">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_200?> DeleteAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_200> DeleteAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_400.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_delete_gateway_logs_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List Gateway Logs
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_400">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_200?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_200> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_400.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Aig_config_list_gateway_logs_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete Gateway Logs
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// List Gateway Logs
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delete Gateway Logs
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LogsRequestBuilderDeleteQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filters")]
            public string[]? Filters { get; set; }
#nullable restore
#else
            [QueryParameter("filters")]
            public string[] Filters { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [Obsolete("This property is deprecated, use OrderByAsDeleteOrderByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            [QueryParameter("order_by")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.DeleteOrder_byQueryParameterType? OrderByAsDeleteOrderByQueryParameterType { get; set; }
            [Obsolete("This property is deprecated, use OrderByDirectionAsDeleteOrderByDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by_direction")]
            public string? OrderByDirection { get; set; }
#nullable restore
#else
            [QueryParameter("order_by_direction")]
            public string OrderByDirection { get; set; }
#endif
            [QueryParameter("order_by_direction")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.DeleteOrder_by_directionQueryParameterType? OrderByDirectionAsDeleteOrderByDirectionQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LogsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// List Gateway Logs
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LogsRequestBuilderGetQueryParameters 
        {
            [Obsolete("")]
            [QueryParameter("cached")]
            public bool? Cached { get; set; }
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
            [Obsolete("")]
            [QueryParameter("direction")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            [Obsolete("")]
            [QueryParameter("end_date")]
            public DateTimeOffset? EndDate { get; set; }
            [Obsolete("")]
            [QueryParameter("feedback")]
            public double? Feedback { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filters")]
            public string[]? Filters { get; set; }
#nullable restore
#else
            [QueryParameter("filters")]
            public string[] Filters { get; set; }
#endif
            [Obsolete("")]
            [QueryParameter("max_cost")]
            public double? MaxCost { get; set; }
            [Obsolete("")]
            [QueryParameter("max_duration")]
            public double? MaxDuration { get; set; }
            [Obsolete("")]
            [QueryParameter("max_tokens_in")]
            public double? MaxTokensIn { get; set; }
            [Obsolete("")]
            [QueryParameter("max_tokens_out")]
            public double? MaxTokensOut { get; set; }
            [Obsolete("")]
            [QueryParameter("max_total_tokens")]
            public double? MaxTotalTokens { get; set; }
            [QueryParameter("meta_info")]
            public bool? MetaInfo { get; set; }
            [Obsolete("")]
            [QueryParameter("min_cost")]
            public double? MinCost { get; set; }
            [Obsolete("")]
            [QueryParameter("min_duration")]
            public double? MinDuration { get; set; }
            [Obsolete("")]
            [QueryParameter("min_tokens_in")]
            public double? MinTokensIn { get; set; }
            [Obsolete("")]
            [QueryParameter("min_tokens_out")]
            public double? MinTokensOut { get; set; }
            [Obsolete("")]
            [QueryParameter("min_total_tokens")]
            public double? MinTotalTokens { get; set; }
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("model")]
            public string? Model { get; set; }
#nullable restore
#else
            [QueryParameter("model")]
            public string Model { get; set; }
#endif
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("model_type")]
            public string? ModelType { get; set; }
#nullable restore
#else
            [QueryParameter("model_type")]
            public string ModelType { get; set; }
#endif
            [Obsolete("This property is deprecated, use OrderByAsGetOrderByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            [QueryParameter("order_by")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.GetOrder_byQueryParameterType? OrderByAsGetOrderByQueryParameterType { get; set; }
            [Obsolete("This property is deprecated, use OrderByDirectionAsGetOrderByDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by_direction")]
            public string? OrderByDirection { get; set; }
#nullable restore
#else
            [QueryParameter("order_by_direction")]
            public string OrderByDirection { get; set; }
#endif
            [QueryParameter("order_by_direction")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.GetOrder_by_directionQueryParameterType? OrderByDirectionAsGetOrderByDirectionQueryParameterType { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("provider")]
            public string? Provider { get; set; }
#nullable restore
#else
            [QueryParameter("provider")]
            public string Provider { get; set; }
#endif
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("request_content_type")]
            public string? RequestContentType { get; set; }
#nullable restore
#else
            [QueryParameter("request_content_type")]
            public string RequestContentType { get; set; }
#endif
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("response_content_type")]
            public string? ResponseContentType { get; set; }
#nullable restore
#else
            [QueryParameter("response_content_type")]
            public string ResponseContentType { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
            [Obsolete("")]
            [QueryParameter("start_date")]
            public DateTimeOffset? StartDate { get; set; }
            [Obsolete("")]
            [QueryParameter("success")]
            public bool? Success { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LogsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.AiGateway.Gateways.Item.Logs.LogsRequestBuilder.LogsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
