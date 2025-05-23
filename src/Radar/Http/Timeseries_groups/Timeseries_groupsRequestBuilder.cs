// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Bot_class;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Browser;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Browser_family;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Device_type;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Http_protocol;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Http_version;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Ip_version;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Os;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Post_quantum;
using Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Tls_version;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\http\timeseries_groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Timeseries_groupsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The bot_class property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Bot_class.Bot_classRequestBuilder Bot_class
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Bot_class.Bot_classRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The browser property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Browser.BrowserRequestBuilder Browser
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Browser.BrowserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The browser_family property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Browser_family.Browser_familyRequestBuilder Browser_family
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Browser_family.Browser_familyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The device_type property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Device_type.Device_typeRequestBuilder Device_type
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Device_type.Device_typeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The http_protocol property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Http_protocol.Http_protocolRequestBuilder Http_protocol
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Http_protocol.Http_protocolRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The http_version property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Http_version.Http_versionRequestBuilder Http_version
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Http_version.Http_versionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ip_version property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Ip_version.Ip_versionRequestBuilder Ip_version
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Ip_version.Ip_versionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The os property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Os.OsRequestBuilder Os
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Os.OsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The post_quantum property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Post_quantum.Post_quantumRequestBuilder Post_quantum
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Post_quantum.Post_quantumRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tls_version property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Tls_version.Tls_versionRequestBuilder Tls_version
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Tls_version.Tls_versionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Timeseries_groupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Timeseries_groupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/http/timeseries_groups", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Http.Timeseries_groups.Timeseries_groupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Timeseries_groupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/http/timeseries_groups", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
