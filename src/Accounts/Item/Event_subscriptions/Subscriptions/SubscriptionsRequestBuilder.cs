// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.Item;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\event_subscriptions\subscriptions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SubscriptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.accounts.item.event_subscriptions.subscriptions.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.Item.WithSubscription_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.Item.WithSubscription_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("subscription_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.Item.WithSubscription_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/event_subscriptions/subscriptions{?direction*,order*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/event_subscriptions/subscriptions{?direction*,order*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Get a paginated list of event subscriptions with optional sorting and filtering
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_list_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_list_200?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_list_200> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_list_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_list_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new event subscription for a queue
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create_200"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure">When receiving a 405 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create_200?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create_200> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure.CreateFromDiscriminatorValue },
                { "405", global::Soenneker.Cloudflare.OpenApiClient.Models.Mq_apiV4Failure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a paginated list of event subscriptions with optional sorting and filtering
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new event subscription for a queue
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Subscriptions_create body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a paginated list of event subscriptions with optional sorting and filtering
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SubscriptionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Sort direction</summary>
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
            /// <summary>Sort direction</summary>
            [QueryParameter("direction")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            /// <summary>Field to sort by</summary>
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
            /// <summary>Field to sort by</summary>
            [QueryParameter("order")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.GetOrderQueryParameterType? OrderAsGetOrderQueryParameterType { get; set; }
            /// <summary>Page number for pagination</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>Number of items per page</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SubscriptionsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder.SubscriptionsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SubscriptionsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
