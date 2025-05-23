// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>Filters by the resource scope, specifying whether the resource is associated with an user, an account, or a zone.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Audit_logs_v2_get_account_audit_logs_Param_resource_scope
    {
        [EnumMember(Value = "accounts")]
        #pragma warning disable CS1591
        Accounts,
        #pragma warning restore CS1591
        [EnumMember(Value = "user")]
        #pragma warning disable CS1591
        User,
        #pragma warning restore CS1591
        [EnumMember(Value = "zones")]
        #pragma warning disable CS1591
        Zones,
        #pragma warning restore CS1591
    }
}
