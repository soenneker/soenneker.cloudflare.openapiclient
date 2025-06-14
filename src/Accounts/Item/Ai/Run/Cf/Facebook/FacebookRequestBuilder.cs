// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.BartLargeCnn;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.DetrResnet50;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.OmniDetrResnet50;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.TritonDetrResnet50;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\ai\run\@cf\facebook
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FacebookRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The bartLargeCnn property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.BartLargeCnn.BartLargeCnnRequestBuilder BartLargeCnn
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.BartLargeCnn.BartLargeCnnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The detrResnet50 property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.DetrResnet50.DetrResnet50RequestBuilder DetrResnet50
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.DetrResnet50.DetrResnet50RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The omniDetrResnet50 property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.OmniDetrResnet50.OmniDetrResnet50RequestBuilder OmniDetrResnet50
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.OmniDetrResnet50.OmniDetrResnet50RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tritonDetrResnet50 property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.TritonDetrResnet50.TritonDetrResnet50RequestBuilder TritonDetrResnet50
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.TritonDetrResnet50.TritonDetrResnet50RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.FacebookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FacebookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai/run/@cf/facebook", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Facebook.FacebookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FacebookRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai/run/@cf/facebook", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
