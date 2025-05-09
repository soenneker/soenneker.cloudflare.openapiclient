// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Devices.Resilience.Disconnect;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Devices.Resilience
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\devices\resilience
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ResilienceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The disconnect property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Devices.Resilience.Disconnect.DisconnectRequestBuilder Disconnect
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Devices.Resilience.Disconnect.DisconnectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Devices.Resilience.ResilienceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResilienceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/devices/resilience", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Devices.Resilience.ResilienceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResilienceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/devices/resilience", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
