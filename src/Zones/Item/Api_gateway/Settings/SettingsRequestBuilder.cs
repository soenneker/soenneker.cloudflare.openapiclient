// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Settings.Schema_validation;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Settings
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\api_gateway\settings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SettingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The schema_validation property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Settings.Schema_validation.Schema_validationRequestBuilder Schema_validation
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Settings.Schema_validation.Schema_validationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Settings.SettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/settings", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Api_gateway.Settings.SettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/api_gateway/settings", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
