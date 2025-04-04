// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Acls;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Peers;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Tsigs;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\secondary_dns
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Secondary_dnsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The acls property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Acls.AclsRequestBuilder Acls
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Acls.AclsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The peers property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Peers.PeersRequestBuilder Peers
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Peers.PeersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tsigs property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Tsigs.TsigsRequestBuilder Tsigs
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Tsigs.TsigsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Secondary_dnsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Secondary_dnsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/secondary_dns", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secondary_dns.Secondary_dnsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Secondary_dnsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/secondary_dns", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
