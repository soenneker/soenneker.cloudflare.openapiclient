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
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\spectrum\analytics\events\bytime
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BytimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BytimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/spectrum/analytics/events/bytime?time_delta={time_delta}{&dimensions*,filters*,metrics*,since*,sort*,until*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BytimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/spectrum/analytics/events/bytime?time_delta={time_delta}{&dimensions*,filters*,metrics*,since*,sort*,until*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves a list of aggregate metrics grouped by time interval.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_queryResponseSingle"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_queryResponseSingle?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder.BytimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_queryResponseSingle> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder.BytimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_queryResponseSingle>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.SpectrumAnalytics_queryResponseSingle.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves a list of aggregate metrics grouped by time interval.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder.BytimeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder.BytimeRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves a list of aggregate metrics grouped by time interval.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BytimeRequestBuilderGetQueryParameters 
        {
            [Obsolete("This property is deprecated, use DimensionsAsGetDimensionsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dimensions")]
            public string[]? Dimensions { get; set; }
#nullable restore
#else
            [QueryParameter("dimensions")]
            public string[] Dimensions { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dimensions")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.GetDimensionsQueryParameterType[]? DimensionsAsGetDimensionsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("dimensions")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.GetDimensionsQueryParameterType[] DimensionsAsGetDimensionsQueryParameterType { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filters")]
            public string? Filters { get; set; }
#nullable restore
#else
            [QueryParameter("filters")]
            public string Filters { get; set; }
#endif
            [Obsolete("This property is deprecated, use MetricsAsGetMetricsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("metrics")]
            public string[]? Metrics { get; set; }
#nullable restore
#else
            [QueryParameter("metrics")]
            public string[] Metrics { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("metrics")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.GetMetricsQueryParameterType[]? MetricsAsGetMetricsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("metrics")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.GetMetricsQueryParameterType[] MetricsAsGetMetricsQueryParameterType { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("since")]
            public string? Since { get; set; }
#nullable restore
#else
            [QueryParameter("since")]
            public string Since { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string[]? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string[] Sort { get; set; }
#endif
            [Obsolete("This property is deprecated, use TimeDeltaAsGetTimeDeltaQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("time_delta")]
            public string? TimeDelta { get; set; }
#nullable restore
#else
            [QueryParameter("time_delta")]
            public string TimeDelta { get; set; }
#endif
            [QueryParameter("time_delta")]
            public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.GetTime_deltaQueryParameterType? TimeDeltaAsGetTimeDeltaQueryParameterType { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("until")]
            public string? Until { get; set; }
#nullable restore
#else
            [QueryParameter("until")]
            public string Until { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BytimeRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Spectrum.Analytics.Events.Bytime.BytimeRequestBuilder.BytimeRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
