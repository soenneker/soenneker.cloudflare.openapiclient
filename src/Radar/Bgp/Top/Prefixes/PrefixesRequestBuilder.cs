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
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\bgp\top\prefixes
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PrefixesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrefixesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bgp/top/prefixes{?asn*,dateEnd*,dateRange*,dateStart*,format*,limit*,name*,updateType*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PrefixesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/bgp/top/prefixes{?asn*,dateEnd*,dateRange*,dateStart*,format*,limit*,name*,updateType*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves the top network prefixes by BGP updates.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_400">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_200?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder.PrefixesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_200> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder.PrefixesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_400.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Radar_get_bgp_top_prefixes_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the top network prefixes by BGP updates.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder.PrefixesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder.PrefixesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves the top network prefixes by BGP updates.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PrefixesRequestBuilderGetQueryParameters 
        {
            /// <summary>Filters results by Autonomous System. Specify one or more Autonomous System Numbers (ASNs) as a comma-separated list. Prefix with `-` to exclude ASNs from results. For example, `-174, 3356` excludes results from AS174, but includes results from AS3356.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("asn")]
            public string[]? Asn { get; set; }
#nullable restore
#else
            [QueryParameter("asn")]
            public string[] Asn { get; set; }
#endif
            /// <summary>End of the date range (inclusive).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dateEnd")]
            public DateTimeOffset?[]? DateEnd { get; set; }
#nullable restore
#else
            [QueryParameter("dateEnd")]
            public DateTimeOffset?[] DateEnd { get; set; }
#endif
            /// <summary>Filters results by date range. For example, use `7d` and `7dcontrol` to compare this week with the previous week. Use this parameter or set specific start and end dates (`dateStart` and `dateEnd` parameters).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dateRange")]
            public string[]? DateRange { get; set; }
#nullable restore
#else
            [QueryParameter("dateRange")]
            public string[] DateRange { get; set; }
#endif
            /// <summary>Start of the date range.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dateStart")]
            public DateTimeOffset?[]? DateStart { get; set; }
#nullable restore
#else
            [QueryParameter("dateStart")]
            public DateTimeOffset?[] DateStart { get; set; }
#endif
            /// <summary>Format in which results will be returned.</summary>
            [Obsolete("This property is deprecated, use FormatAsGetFormatQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>Format in which results will be returned.</summary>
            [QueryParameter("format")]
            public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.GetFormatQueryParameterType? FormatAsGetFormatQueryParameterType { get; set; }
            /// <summary>Limits the number of objects returned in the response.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Array of names used to label the series in the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string[]? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string[] Name { get; set; }
#endif
            /// <summary>Filters results by BGP update type.</summary>
            [Obsolete("This property is deprecated, use UpdateTypeAsGetUpdateTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("updateType")]
            public string[]? UpdateType { get; set; }
#nullable restore
#else
            [QueryParameter("updateType")]
            public string[] UpdateType { get; set; }
#endif
            /// <summary>Filters results by BGP update type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("updateType")]
            public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.GetUpdateTypeQueryParameterType[]? UpdateTypeAsGetUpdateTypeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("updateType")]
            public global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.GetUpdateTypeQueryParameterType[] UpdateTypeAsGetUpdateTypeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PrefixesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Radar.Bgp.Top.Prefixes.PrefixesRequestBuilder.PrefixesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
