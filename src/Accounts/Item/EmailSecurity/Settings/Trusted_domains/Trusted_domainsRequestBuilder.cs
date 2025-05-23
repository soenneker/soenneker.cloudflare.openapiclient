// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Item;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\email-security\settings\trusted_domains
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Trusted_domainsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.accounts.item.emailSecurity.settings.trusted_domains.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Item.WithTrusted_domain_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Item.WithTrusted_domain_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("trusted_domain_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Item.WithTrusted_domain_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Trusted_domainsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/email-security/settings/trusted_domains{?direction*,is_recent*,is_similarity*,order*,page*,per_page*,search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Trusted_domainsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/email-security/settings/trusted_domains{?direction*,is_recent*,is_similarity*,order*,page*,per_page*,search*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists, searches, and sorts an account’s trusted email domains.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">Fallback request body schema</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_investigate_Response_4XX_application_json">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_list_trusted_domains_RequestBody_application_json body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder.Trusted_domainsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_list_trusted_domains_RequestBody_application_json body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder.Trusted_domainsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToGetRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_investigate_Response_4XX_application_json.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a trusted email domain
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">Fallback request body schema</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_investigate_Response_4XX_application_json">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_create_trusted_domain_RequestBody_application_json body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_create_trusted_domain_RequestBody_application_json body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_investigate_Response_4XX_application_json.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists, searches, and sorts an account’s trusted email domains.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Fallback request body schema</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_list_trusted_domains_RequestBody_application_json body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder.Trusted_domainsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_list_trusted_domains_RequestBody_application_json body, Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder.Trusted_domainsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Create a trusted email domain
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Fallback request body schema</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_create_trusted_domain_RequestBody_application_json body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_create_trusted_domain_RequestBody_application_json body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists, searches, and sorts an account’s trusted email domains.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Trusted_domainsRequestBuilderGetQueryParameters 
        {
            /// <summary>The sorting direction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("direction")]
            public string? Direction { get; set; }
#nullable restore
#else
            [QueryParameter("direction")]
            public string Direction { get; set; }
#endif
            [QueryParameter("is_recent")]
            public bool? IsRecent { get; set; }
            [QueryParameter("is_similarity")]
            public bool? IsSimilarity { get; set; }
            /// <summary>The field to sort by.</summary>
            [Obsolete("This property is deprecated, use OrderAsEmailSecurityListTrustedDomainsParamOrder instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order")]
            public string? Order { get; set; }
#nullable restore
#else
            [QueryParameter("order")]
            public string Order { get; set; }
#endif
            /// <summary>The field to sort by.</summary>
            [QueryParameter("order")]
            public global::Soenneker.Cloudflare.OpenApiClient.Models.Email_security_list_trusted_domains_Param_order? OrderAsEmailSecurityListTrustedDomainsParamOrder { get; set; }
            /// <summary>The page number of paginated results.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page.</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Allows searching in multiple properties of a record simultaneously.This parameter is intended for human users, not automation. Its exactbehavior is intentionally left unspecified and is subject to changein the future.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Trusted_domainsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.EmailSecurity.Settings.Trusted_domains.Trusted_domainsRequestBuilder.Trusted_domainsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Trusted_domainsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
