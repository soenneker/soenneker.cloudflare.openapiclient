// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Mistralai.MistralSmall3124bInstruct;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Mistralai
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\ai\run\@cf\mistralai
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MistralaiRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The mistralSmall3124bInstruct property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Mistralai.MistralSmall3124bInstruct.MistralSmall3124bInstructRequestBuilder MistralSmall3124bInstruct
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Mistralai.MistralSmall3124bInstruct.MistralSmall3124bInstructRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Mistralai.MistralaiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MistralaiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai/run/@cf/mistralai", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Mistralai.MistralaiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MistralaiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai/run/@cf/mistralai", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
