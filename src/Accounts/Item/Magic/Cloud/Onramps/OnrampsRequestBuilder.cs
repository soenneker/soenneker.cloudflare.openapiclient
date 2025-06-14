// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Magic_wan_address_space;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\magic\cloud\onramps
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OnrampsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The magic_wan_address_space property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Magic_wan_address_space.Magic_wan_address_spaceRequestBuilder Magic_wan_address_space
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Magic_wan_address_space.Magic_wan_address_spaceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.accounts.item.magic.cloud.onramps.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item.WithOnramp_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item.WithOnramp_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("onramp_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item.WithOnramp_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.accounts.item.magic.cloud.onramps.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item.WithOnramp_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item.WithOnramp_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("onramp_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.Item.WithOnramp_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnrampsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/magic/cloud/onramps{?desc*,order_by*,status*,vpcs*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnrampsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/magic/cloud/onramps{?desc*,order_by*,status*,vpcs*}", rawUrl)
        {
        }
        /// <summary>
        /// List On-ramps (Closed Beta).
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_onramps_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_onramps_response?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder.OnrampsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_onramps_response> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder.OnrampsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_onramps_response>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_list_onramps_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new On-ramp (Closed Beta).
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 409 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_response?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_response> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "409", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_bad_response.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_response>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List On-ramps (Closed Beta).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder.OnrampsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder.OnrampsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new On-ramp (Closed Beta).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Mcn_create_onramp_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List On-ramps (Closed Beta).
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnrampsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("desc")]
            public bool? Desc { get; set; }
            /// <summary>One of [&quot;updated_at&quot;, &quot;id&quot;, &quot;cloud_type&quot;, &quot;name&quot;].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            [QueryParameter("status")]
            public bool? Status { get; set; }
            [QueryParameter("vpcs")]
            public bool? Vpcs { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnrampsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Magic.Cloud.Onramps.OnrampsRequestBuilder.OnrampsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnrampsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
