// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Access_rules;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Lockdowns;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Rules;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Ua_rules;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Waf;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\firewall
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FirewallRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The access_rules property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Access_rules.Access_rulesRequestBuilder Access_rules
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Access_rules.Access_rulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lockdowns property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Lockdowns.LockdownsRequestBuilder Lockdowns
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Lockdowns.LockdownsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rules property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Rules.RulesRequestBuilder Rules
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Rules.RulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ua_rules property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Ua_rules.Ua_rulesRequestBuilder Ua_rules
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Ua_rules.Ua_rulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The waf property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Waf.WafRequestBuilder Waf
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.Waf.WafRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.FirewallRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FirewallRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/firewall", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Firewall.FirewallRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FirewallRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/firewall", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
