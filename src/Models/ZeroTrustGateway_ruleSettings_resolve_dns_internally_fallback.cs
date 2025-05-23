// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>The fallback behavior to apply when the internal DNS response code is different from &apos;NOERROR&apos; or when the response data only contains CNAME records for &apos;A&apos; or &apos;AAAA&apos; queries.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ZeroTrustGateway_ruleSettings_resolve_dns_internally_fallback
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "public_dns")]
        #pragma warning disable CS1591
        Public_dns,
        #pragma warning restore CS1591
    }
}
