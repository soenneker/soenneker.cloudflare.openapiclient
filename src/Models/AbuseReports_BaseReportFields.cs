// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AbuseReports_BaseReportFields : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The abuse report type</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_ReportType? Act { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Text not exceeding 100 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address1 { get; set; }
#nullable restore
#else
        public string Address1 { get; set; }
#endif
        /// <summary>The name of the copyright holder. Text not exceeding 60 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgentName { get; set; }
#nullable restore
#else
        public string AgentName { get; set; }
#endif
        /// <summary>Can be `0` for false or `1` for true. Must be value: 1 for DMCA reports</summary>
        public int? Agree { get; set; }
        /// <summary>Text not exceeding 255 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Any additional comments about the infringement not exceeding 2000 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comments { get; set; }
#nullable restore
#else
        public string Comments { get; set; }
#endif
        /// <summary>Text not exceeding 100 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company { get; set; }
#nullable restore
#else
        public string Company { get; set; }
#endif
        /// <summary>Text not exceeding 255 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>A list of IP addresses separated by ‘’ (new line character). The list of destination IPs should not exceed 30 IP addresses. Each one of the IP addresses ought to be unique</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationIps { get; set; }
#nullable restore
#else
        public string DestinationIps { get; set; }
#endif
        /// <summary>A valid email of the abuse reporter. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Should match the value provided in `email`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email2 { get; set; }
#nullable restore
#else
        public string Email2 { get; set; }
#endif
        /// <summary>Notification type based on the abuse type. NOTE: Copyright (DMCA) and Trademark reports cannot be anonymous.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification? HostNotification { get; set; }
        /// <summary>A detailed description of the infringement, including any necessary access details and the exact steps needed to view the content, not exceeding 5000 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>Text not exceeding 255 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Notification type based on the abuse type. NOTE: Copyright (DMCA) and Trademark reports cannot be anonymous.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification? NcmecNotification { get; set; }
        /// <summary>If the submitter is the target of NCSEI in the URLs of the abuse report.</summary>
        public bool? NcseiSubjectRepresentation { get; set; }
        /// <summary>Text not exceeding 255 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalWork { get; set; }
#nullable restore
#else
        public string OriginalWork { get; set; }
#endif
        /// <summary>Notification type based on the abuse type. NOTE: Copyright (DMCA) and Trademark reports cannot be anonymous.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification? OwnerNotification { get; set; }
        /// <summary>A comma separated list of ports and protocols e.g. 80/TCP, 22/UDP. The total size of the field should not exceed 2000 characters. Each individual port/protocol should not exceed 100 characters. The list should not have more than 30 unique ports and protocols.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PortsProtocols { get; set; }
#nullable restore
#else
        public string PortsProtocols { get; set; }
#endif
        /// <summary>Text containing 2 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportedCountry { get; set; }
#nullable restore
#else
        public string ReportedCountry { get; set; }
#endif
        /// <summary>Text not exceeding 255 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportedUserAgent { get; set; }
#nullable restore
#else
        public string ReportedUserAgent { get; set; }
#endif
        /// <summary>Required for DMCA reports, should be same as Name. An affirmation that all information in the report is true and accurate while agreeing to the policies of Cloudflare&apos;s abuse reports</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Signature { get; set; }
#nullable restore
#else
        public string Signature { get; set; }
#endif
        /// <summary>A list of IP addresses separated by ‘’ (new line character). The list of source IPs should not exceed 30 IP addresses. Each one of the IP addresses ought to be unique</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceIps { get; set; }
#nullable restore
#else
        public string SourceIps { get; set; }
#endif
        /// <summary>Text not exceeding 255 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Text not exceeding 20 characters. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tele { get; set; }
#nullable restore
#else
        public string Tele { get; set; }
#endif
        /// <summary>Text not exceeding 255 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Text not exceeding 1000 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrademarkNumber { get; set; }
#nullable restore
#else
        public string TrademarkNumber { get; set; }
#endif
        /// <summary>Text not exceeding 1000 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrademarkOffice { get; set; }
#nullable restore
#else
        public string TrademarkOffice { get; set; }
#endif
        /// <summary>Text not exceeding 1000 characters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrademarkSymbol { get; set; }
#nullable restore
#else
        public string TrademarkSymbol { get; set; }
#endif
        /// <summary>A list of valid URLs separated by ‘’ (new line character). The list of the URLs should not exceed 250 URLs. All URLs should have the same hostname. Each URL should be unique. This field may be released by Cloudflare to third parties such as the Lumen Database (https://lumendatabase.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urls { get; set; }
#nullable restore
#else
        public string Urls { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_BaseReportFields"/> and sets the default values.
        /// </summary>
        public AbuseReports_BaseReportFields()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_BaseReportFields"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_BaseReportFields CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_BaseReportFields();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "act", n => { Act = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_ReportType>(); } },
                { "address1", n => { Address1 = n.GetStringValue(); } },
                { "agent_name", n => { AgentName = n.GetStringValue(); } },
                { "agree", n => { Agree = n.GetIntValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "comments", n => { Comments = n.GetStringValue(); } },
                { "company", n => { Company = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "destination_ips", n => { DestinationIps = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "email2", n => { Email2 = n.GetStringValue(); } },
                { "host_notification", n => { HostNotification = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification>(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "ncmec_notification", n => { NcmecNotification = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification>(); } },
                { "ncsei_subject_representation", n => { NcseiSubjectRepresentation = n.GetBoolValue(); } },
                { "original_work", n => { OriginalWork = n.GetStringValue(); } },
                { "owner_notification", n => { OwnerNotification = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification>(); } },
                { "ports_protocols", n => { PortsProtocols = n.GetStringValue(); } },
                { "reported_country", n => { ReportedCountry = n.GetStringValue(); } },
                { "reported_user_agent", n => { ReportedUserAgent = n.GetStringValue(); } },
                { "signature", n => { Signature = n.GetStringValue(); } },
                { "source_ips", n => { SourceIps = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "tele", n => { Tele = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "trademark_number", n => { TrademarkNumber = n.GetStringValue(); } },
                { "trademark_office", n => { TrademarkOffice = n.GetStringValue(); } },
                { "trademark_symbol", n => { TrademarkSymbol = n.GetStringValue(); } },
                { "urls", n => { Urls = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_ReportType>("act", Act);
            writer.WriteStringValue("address1", Address1);
            writer.WriteStringValue("agent_name", AgentName);
            writer.WriteIntValue("agree", Agree);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("comments", Comments);
            writer.WriteStringValue("company", Company);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("destination_ips", DestinationIps);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("email2", Email2);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification>("host_notification", HostNotification);
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification>("ncmec_notification", NcmecNotification);
            writer.WriteBoolValue("ncsei_subject_representation", NcseiSubjectRepresentation);
            writer.WriteStringValue("original_work", OriginalWork);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.AbuseReports_Notification>("owner_notification", OwnerNotification);
            writer.WriteStringValue("ports_protocols", PortsProtocols);
            writer.WriteStringValue("reported_country", ReportedCountry);
            writer.WriteStringValue("reported_user_agent", ReportedUserAgent);
            writer.WriteStringValue("signature", Signature);
            writer.WriteStringValue("source_ips", SourceIps);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("tele", Tele);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("trademark_number", TrademarkNumber);
            writer.WriteStringValue("trademark_office", TrademarkOffice);
            writer.WriteStringValue("trademark_symbol", TrademarkSymbol);
            writer.WriteStringValue("urls", Urls);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
