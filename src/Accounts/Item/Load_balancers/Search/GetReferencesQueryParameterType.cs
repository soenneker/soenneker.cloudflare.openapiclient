// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Accounts.Item.Load_balancers.Search
{
    /// <summary>The type of references to include. &quot;*&quot; to include both referral and referrer references. &quot;&quot; to not include any reference information.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum GetReferencesQueryParameterType
    {
        [EnumMember(Value = "*")]
        #pragma warning disable CS1591
        Asterisk,
        #pragma warning restore CS1591
        [EnumMember(Value = "referral")]
        #pragma warning disable CS1591
        Referral,
        #pragma warning restore CS1591
        [EnumMember(Value = "referrer")]
        #pragma warning disable CS1591
        Referrer,
        #pragma warning restore CS1591
    }
}
