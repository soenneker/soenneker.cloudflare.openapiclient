// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\email\security\top\tlds\spoof
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SpoofRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.radar.email.security.top.tlds.spoof.item collection</summary>
        /// <param name="position">Spoof classification.</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof.Item.WithSpoofItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof.Item.WithSpoofItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("spoof", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof.Item.WithSpoofItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof.SpoofRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SpoofRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/email/security/top/tlds/spoof", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Radar.Email.Security.Top.Tlds.Spoof.SpoofRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SpoofRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/email/security/top/tlds/spoof", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
