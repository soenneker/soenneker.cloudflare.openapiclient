// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.Devices;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.Live;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.OverTime;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\dex\fleet-status
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FleetStatusRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The devices property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.Devices.DevicesRequestBuilder Devices
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.Devices.DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The live property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.Live.LiveRequestBuilder Live
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.Live.LiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The overTime property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.OverTime.OverTimeRequestBuilder OverTime
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.OverTime.OverTimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.FleetStatusRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FleetStatusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/dex/fleet-status", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.FleetStatus.FleetStatusRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FleetStatusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/dex/fleet-status", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
