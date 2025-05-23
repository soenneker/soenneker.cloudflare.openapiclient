// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.Downloads;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\dex\commands\{command_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithCommand_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The downloads property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.Downloads.DownloadsRequestBuilder Downloads
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.Downloads.DownloadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.WithCommand_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCommand_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/dex/commands/{command_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.WithCommand_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCommand_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/dex/commands/{command_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
