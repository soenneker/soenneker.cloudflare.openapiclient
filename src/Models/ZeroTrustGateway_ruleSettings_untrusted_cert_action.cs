// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>The action performed when an untrusted certificate is seen. The default action is an error with HTTP code 526.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ZeroTrustGateway_ruleSettings_untrusted_cert_action
    {
        [EnumMember(Value = "pass_through")]
        #pragma warning disable CS1591
        Pass_through,
        #pragma warning restore CS1591
        [EnumMember(Value = "block")]
        #pragma warning disable CS1591
        Block,
        #pragma warning restore CS1591
        [EnumMember(Value = "error")]
        #pragma warning disable CS1591
        Error,
        #pragma warning restore CS1591
    }
}
