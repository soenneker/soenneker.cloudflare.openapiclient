// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Devices;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item;
using Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Quota;
using Soenneker.Cloudflare.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_identifier-id}\dex\commands
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CommandsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The devices property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Devices.DevicesRequestBuilder Devices
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Devices.DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The quota property</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Quota.QuotaRequestBuilder Quota
        {
            get => new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Quota.QuotaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Cloudflare.OpenApiClient.accounts.item.dex.commands.item collection</summary>
        /// <param name="position">Unique identifier for command</param>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.WithCommand_ItemRequestBuilder"/></returns>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.WithCommand_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("command_id", position);
                return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.Item.WithCommand_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommandsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/dex/commands?page={page}&per_page={per_page}{&command_type*,device_id*,from*,status*,to*,user_email*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommandsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_identifier%2Did}/dex/commands?page={page}&per_page={per_page}{&command_type*,device_id*,from*,status*,to*,user_email*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves a paginated list of commands issued to devices under the specified account, optionally filtered by time range, device, or other parameters
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Get_commands_200"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Get_commands_200?> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder.CommandsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Get_commands_200> GetAsync(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder.CommandsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Get_commands_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Get_commands_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Initiate commands for up to 10 devices per account
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands_200"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_apiResponseCommonFailure">When receiving a 4XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands_200?> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands_200> PostAsync(global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Soenneker.Cloudflare.OpenApiClient.Models.DigitalExperienceMonitoring_apiResponseCommonFailure.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands_200>(requestInfo, global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands_200.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves a paginated list of commands issued to devices under the specified account, optionally filtered by time range, device, or other parameters
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder.CommandsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder.CommandsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Initiate commands for up to 10 devices per account
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Cloudflare.OpenApiClient.Models.Post_commands body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/accounts/{account_identifier%2Did}/dex/commands", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves a paginated list of commands issued to devices under the specified account, optionally filtered by time range, device, or other parameters
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CommandsRequestBuilderGetQueryParameters 
        {
            /// <summary>Optionally filter executed commands by command type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("command_type")]
            public string? CommandType { get; set; }
#nullable restore
#else
            [QueryParameter("command_type")]
            public string CommandType { get; set; }
#endif
            /// <summary>Unique identifier for a device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("device_id")]
            public string? DeviceId { get; set; }
#nullable restore
#else
            [QueryParameter("device_id")]
            public string DeviceId { get; set; }
#endif
            /// <summary>Start time for the query in ISO (RFC3339 - ISO 8601) format</summary>
            [QueryParameter("from")]
            public DateTimeOffset? From { get; set; }
            /// <summary>Page number for pagination</summary>
            [QueryParameter("page")]
            public double? Page { get; set; }
            /// <summary>Number of results per page</summary>
            [QueryParameter("per_page")]
            public double? PerPage { get; set; }
            /// <summary>Optionally filter executed commands by status</summary>
            [Obsolete("This property is deprecated, use StatusAsGetStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public string? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public string Status { get; set; }
#endif
            /// <summary>Optionally filter executed commands by status</summary>
            [QueryParameter("status")]
            public global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.GetStatusQueryParameterType? StatusAsGetStatusQueryParameterType { get; set; }
            /// <summary>End time for the query in ISO (RFC3339 - ISO 8601) format</summary>
            [QueryParameter("to")]
            public DateTimeOffset? To { get; set; }
            /// <summary>Email tied to the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_email")]
            public string? UserEmail { get; set; }
#nullable restore
#else
            [QueryParameter("user_email")]
            public string UserEmail { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CommandsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Dex.Commands.CommandsRequestBuilder.CommandsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CommandsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
