// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Hosts;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\api_gateway\user_schemas
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class User_schemasRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The hosts property</summary>
        [Obsolete("")]
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Hosts.HostsRequestBuilder Hosts
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Hosts.HostsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.zones.item.api_gateway.user_schemas.item collection</summary>
        /// <param name="position">Identifier for the schema-ID</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item.WithSchema_ItemRequestBuilder"/></returns>
        [Obsolete("")]
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item.WithSchema_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("schema_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item.WithSchema_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.zones.item.api_gateway.user_schemas.item collection</summary>
        /// <param name="position">Identifier for the schema-ID</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item.WithSchema_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item.WithSchema_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("schema_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.Item.WithSchema_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public User_schemasRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/user_schemas{?omit_source*,page*,per_page*,validation_enabled*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public User_schemasRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/user_schemas{?omit_source*,page*,per_page*,validation_enabled*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve information about all schemas on a zone
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_4XX">When receiving a 4XX status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_200?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder.User_schemasRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_200> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder.User_schemasRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_4XX.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_retrieve_information_about_all_schemas_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Upload a schema to a zone
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_post_schema_200"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_schema_upload_failure">When receiving a 4XX status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_post_schema_200?> PostAsync(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_post_schema_200> PostAsync(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.ApiShield_schema_upload_failure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_post_schema_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Api_shield_schema_validation_post_schema_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve information about all schemas on a zone
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder.User_schemasRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder.User_schemasRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Upload a schema to a zone
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve information about all schemas on a zone
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class User_schemasRequestBuilderGetQueryParameters 
        {
            /// <summary>Omit the source-files of schemas and only retrieve their meta-data.</summary>
            [QueryParameter("omit_source")]
            public bool? OmitSource { get; set; }
            /// <summary>Page number of paginated results.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>Maximum number of results per page.</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [QueryParameter("validation_enabled")]
            public bool? ValidationEnabled { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class User_schemasRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.User_schemas.User_schemasRequestBuilder.User_schemasRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class User_schemasRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
