// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>Status of the certificate or the association.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum TlsCertificatesAndHostnames_hostnameAuthenticatedOriginPull_componentsSchemasStatus
    {
        [EnumMember(Value = "initializing")]
        #pragma warning disable CS1591
        Initializing,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending_deployment")]
        #pragma warning disable CS1591
        Pending_deployment,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending_deletion")]
        #pragma warning disable CS1591
        Pending_deletion,
        #pragma warning restore CS1591
        [EnumMember(Value = "active")]
        #pragma warning disable CS1591
        Active,
        #pragma warning restore CS1591
        [EnumMember(Value = "deleted")]
        #pragma warning disable CS1591
        Deleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "deployment_timed_out")]
        #pragma warning disable CS1591
        Deployment_timed_out,
        #pragma warning restore CS1591
        [EnumMember(Value = "deletion_timed_out")]
        #pragma warning disable CS1591
        Deletion_timed_out,
        #pragma warning restore CS1591
    }
}
