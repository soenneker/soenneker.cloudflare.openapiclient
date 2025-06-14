// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Firewall.Access_rules.Rules
{
    /// <summary>Defines the target to search in existing rules.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum GetConfigurationTargetQueryParameterType
    {
        [EnumMember(Value = "ip")]
        #pragma warning disable CS1591
        Ip,
        #pragma warning restore CS1591
        [EnumMember(Value = "ip_range")]
        #pragma warning disable CS1591
        Ip_range,
        #pragma warning restore CS1591
        [EnumMember(Value = "asn")]
        #pragma warning disable CS1591
        Asn,
        #pragma warning restore CS1591
        [EnumMember(Value = "country")]
        #pragma warning disable CS1591
        Country,
        #pragma warning restore CS1591
    }
}
