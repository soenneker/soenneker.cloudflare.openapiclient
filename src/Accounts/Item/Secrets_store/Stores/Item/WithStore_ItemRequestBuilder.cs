// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secrets_store.Stores.Item.Secrets;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secrets_store.Stores.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\secrets_store\stores\{store_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithStore_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The secrets property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secrets_store.Stores.Item.Secrets.SecretsRequestBuilder Secrets
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secrets_store.Stores.Item.Secrets.SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secrets_store.Stores.Item.WithStore_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStore_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/secrets_store/stores/{store_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Secrets_store.Stores.Item.WithStore_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStore_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/secrets_store/stores/{store_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
