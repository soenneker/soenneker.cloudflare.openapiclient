// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.Access_requests;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.Scim;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\access\logs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LogsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The access_requests property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.Access_requests.Access_requestsRequestBuilder Access_requests
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.Access_requests.Access_requestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scim property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.Scim.ScimRequestBuilder Scim
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.Scim.ScimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.LogsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LogsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/access/logs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Access.Logs.LogsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LogsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/access/logs", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
