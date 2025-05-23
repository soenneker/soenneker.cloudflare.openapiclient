// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.Config;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.Rules;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.VpcFlows;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\mnm
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MnmRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The config property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.Config.ConfigRequestBuilder Config
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rules property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.Rules.RulesRequestBuilder Rules
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.Rules.RulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The vpcFlows property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.VpcFlows.VpcFlowsRequestBuilder VpcFlows
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.VpcFlows.VpcFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.MnmRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MnmRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/mnm", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Mnm.MnmRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MnmRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/mnm", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
