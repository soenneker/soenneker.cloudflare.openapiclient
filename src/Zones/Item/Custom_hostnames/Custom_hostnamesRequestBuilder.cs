// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Fallback_origin;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\custom_hostnames
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Custom_hostnamesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The fallback_origin property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Fallback_origin.Fallback_originRequestBuilder Fallback_origin
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Fallback_origin.Fallback_originRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.zones.item.custom_hostnames.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.WithCustom_hostname_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.WithCustom_hostname_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("custom_hostname_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.WithCustom_hostname_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Custom_hostnamesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/custom_hostnames{?direction*,hostname*,id*,order*,page*,per_page*,ssl*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Custom_hostnamesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/custom_hostnames{?direction*,hostname*,id*,order*,page*,per_page*,ssl*}", rawUrl)
        {
        }
        /// <summary>
        /// List, search, sort, and filter all of your custom hostnames.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_collection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_list_custom_hostnames_4XX">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_collection?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder.Custom_hostnamesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_collection> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder.Custom_hostnamesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_list_custom_hostnames_4XX.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_collection>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_collection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Add a new custom hostname and request that an SSL certificate be issued for it. One of three validation methods—http, txt, email—should be used, with &apos;http&apos; recommended if the CNAME is already in place (or will be soon). Specifying &apos;email&apos; will send an email to the WHOIS contacts on file for the base domain plus hostmaster, postmaster, webmaster, admin, administrator. If http is used and the domain is not already pointing to the Managed CNAME host, the PATCH method must be used once it is (to complete validation).  Enable bundling of certificates using the custom_cert_bundle field. The bundling process requires the following condition One certificate in the bundle must use an RSA, and the other must use an ECDSA.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_single"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_create_custom_hostname_4XX">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_single?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_create_custom_hostname body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_single> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_create_custom_hostname body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_create_custom_hostname_4XX.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_single>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.TlsCertificatesAndHostnames_custom_hostname_response_single.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List, search, sort, and filter all of your custom hostnames.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder.Custom_hostnamesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder.Custom_hostnamesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Add a new custom hostname and request that an SSL certificate be issued for it. One of three validation methods—http, txt, email—should be used, with &apos;http&apos; recommended if the CNAME is already in place (or will be soon). Specifying &apos;email&apos; will send an email to the WHOIS contacts on file for the base domain plus hostmaster, postmaster, webmaster, admin, administrator. If http is used and the domain is not already pointing to the Managed CNAME host, the PATCH method must be used once it is (to complete validation).  Enable bundling of certificates using the custom_cert_bundle field. The bundling process requires the following condition One certificate in the bundle must use an RSA, and the other must use an ECDSA.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_create_custom_hostname body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Custom_hostname_for_a_zone_create_custom_hostname body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List, search, sort, and filter all of your custom hostnames.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Custom_hostnamesRequestBuilderGetQueryParameters 
        {
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
            [QueryParameter("direction")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("hostname")]
            public string? Hostname { get; set; }
#nullable restore
#else
            [QueryParameter("hostname")]
            public string Hostname { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public string Id { get; set; }
#endif
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
            [QueryParameter("order")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.GetOrderQueryParameterType? OrderAsGetOrderQueryParameterType { get; set; }
            [QueryParameter("page")]
            public double? Page { get; set; }
            [QueryParameter("per_page")]
            public double? PerPage { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ssl")]
            public string? Ssl { get; set; }
#nullable restore
#else
            [QueryParameter("ssl")]
            public string Ssl { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Custom_hostnamesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Custom_hostnamesRequestBuilder.Custom_hostnamesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Custom_hostnamesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
