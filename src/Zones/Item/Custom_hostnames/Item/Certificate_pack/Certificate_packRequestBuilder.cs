// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{zone_identifier-id}\custom_hostnames\{custom_hostname_id}\certificate_pack
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Certificate_packRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.zones.item.custom_hostnames.item.certificate_pack.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack.Item.WithCertificate_pack_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack.Item.WithCertificate_pack_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("certificate_pack_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack.Item.WithCertificate_pack_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack.Certificate_packRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Certificate_packRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/custom_hostnames/{custom_hostname_id}/certificate_pack", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Zones.Item.Custom_hostnames.Item.Certificate_pack.Certificate_packRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Certificate_packRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{zone_identifier%2Did}/custom_hostnames/{custom_hostname_id}/certificate_pack", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
