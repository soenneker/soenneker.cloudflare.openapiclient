// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.Fields;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\logs\received
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReceivedRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The fields property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.Fields.FieldsRequestBuilder Fields
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.Fields.FieldsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReceivedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/logs/received?end={end}{&count*,fields*,sample*,start*,timestamps*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReceivedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/logs/received?end={end}{&count*,fields*,sample*,start*,timestamps*}", rawUrl)
        {
        }
        /// <summary>
        /// The `/received` api route allows customers to retrieve their edge HTTP logs. The basic access pattern is &quot;give me all the logs for zone Z for minute M&quot;, where the minute M refers to the time records were received at Cloudflare&apos;s central data center. `start` is inclusive, and `end` is exclusive. Because of that, to get all data, at minutely cadence, starting at 10AM, the proper values are: `start=2018-05-20T10:00:00Z&amp;end=2018-05-20T10:01:00Z`, then `start=2018-05-20T10:01:00Z&amp;end=2018-05-20T10:02:00Z` and so on; the overlap will be handled properly.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Logshare_logs_response_json_lines"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Get_zones_zone_id_logs_received_4XX">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Logshare_logs_response_json_lines?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder.ReceivedRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Logshare_logs_response_json_lines> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder.ReceivedRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Get_zones_zone_id_logs_received_4XX.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Logshare_logs_response_json_lines>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Logshare_logs_response_json_lines.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The `/received` api route allows customers to retrieve their edge HTTP logs. The basic access pattern is &quot;give me all the logs for zone Z for minute M&quot;, where the minute M refers to the time records were received at Cloudflare&apos;s central data center. `start` is inclusive, and `end` is exclusive. Because of that, to get all data, at minutely cadence, starting at 10AM, the proper values are: `start=2018-05-20T10:00:00Z&amp;end=2018-05-20T10:01:00Z`, then `start=2018-05-20T10:01:00Z&amp;end=2018-05-20T10:02:00Z` and so on; the overlap will be handled properly.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder.ReceivedRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder.ReceivedRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The `/received` api route allows customers to retrieve their edge HTTP logs. The basic access pattern is &quot;give me all the logs for zone Z for minute M&quot;, where the minute M refers to the time records were received at Cloudflare&apos;s central data center. `start` is inclusive, and `end` is exclusive. Because of that, to get all data, at minutely cadence, starting at 10AM, the proper values are: `start=2018-05-20T10:00:00Z&amp;end=2018-05-20T10:01:00Z`, then `start=2018-05-20T10:01:00Z&amp;end=2018-05-20T10:02:00Z` and so on; the overlap will be handled properly.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReceivedRequestBuilderGetQueryParameters 
        {
            [QueryParameter("count")]
            public int? Count { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end")]
            public string? End { get; set; }
#nullable restore
#else
            [QueryParameter("end")]
            public string End { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
            [QueryParameter("sample")]
            public double? Sample { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start")]
            public string? Start { get; set; }
#nullable restore
#else
            [QueryParameter("start")]
            public string Start { get; set; }
#endif
            [Obsolete("This property is deprecated, use TimestampsAsLogshareTimestamps instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("timestamps")]
            public string? Timestamps { get; set; }
#nullable restore
#else
            [QueryParameter("timestamps")]
            public string Timestamps { get; set; }
#endif
            [QueryParameter("timestamps")]
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Logshare_timestamps? TimestampsAsLogshareTimestamps { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReceivedRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Logs.Received.ReceivedRequestBuilder.ReceivedRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
