// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Zones.Item.Client_certificates
{
    /// <summary>Client Certitifcate Status to filter results by.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum GetStatusQueryParameterType
    {
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
        [EnumMember(Value = "active")]
        #pragma warning disable CS1591
        Active,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending_reactivation")]
        #pragma warning disable CS1591
        Pending_reactivation,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending_revocation")]
        #pragma warning disable CS1591
        Pending_revocation,
        #pragma warning restore CS1591
        [EnumMember(Value = "revoked")]
        #pragma warning disable CS1591
        Revoked,
        #pragma warning restore CS1591
    }
}
