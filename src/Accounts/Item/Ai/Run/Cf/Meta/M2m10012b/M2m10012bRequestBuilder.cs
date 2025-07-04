// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\ai\run\@cf\meta\m2m100-1.2b
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class M2m10012bRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public M2m10012bRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai/run/@cf/meta/m2m100-1.2b{?queueRequest*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public M2m10012bRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/ai/run/@cf/meta/m2m100-1.2b{?queueRequest*}", rawUrl)
        {
        }
        /// <summary>
        /// Execute @cf/meta/m2m100-1.2b model.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_200"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_400">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_200?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder.M2m10012bRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_200> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder.M2m10012bRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_400.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Execute @cf/meta/m2m100-1.2b model.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder.M2m10012bRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Workers_ai_post_run_cf_meta_m2m100_1_2b body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder.M2m10012bRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Execute @cf/meta/m2m100-1.2b model.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class M2m10012bRequestBuilderPostQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("queueRequest")]
            public string? QueueRequest { get; set; }
#nullable restore
#else
            [QueryParameter("queueRequest")]
            public string QueueRequest { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class M2m10012bRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Ai.Run.Cf.Meta.M2m10012b.M2m10012bRequestBuilder.M2m10012bRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
