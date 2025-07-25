// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\event_subscriptions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Event_subscriptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The subscriptions property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder Subscriptions
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Event_subscriptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Event_subscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/event_subscriptions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Event_subscriptions.Event_subscriptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Event_subscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/event_subscriptions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
