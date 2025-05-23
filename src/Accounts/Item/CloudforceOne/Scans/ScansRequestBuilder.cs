// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.Config;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.Results;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\cloudforce-one\scans
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScansRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The config property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.Config.ConfigRequestBuilder Config
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The results property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.Results.ResultsRequestBuilder Results
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.Results.ResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.ScansRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScansRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/cloudforce-one/scans", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.CloudforceOne.Scans.ScansRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScansRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/cloudforce-one/scans", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
