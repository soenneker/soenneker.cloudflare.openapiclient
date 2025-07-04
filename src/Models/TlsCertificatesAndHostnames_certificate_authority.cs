// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>The Certificate Authority that will issue the certificate</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum TlsCertificatesAndHostnames_certificate_authority
    {
        [EnumMember(Value = "digicert")]
        #pragma warning disable CS1591
        Digicert,
        #pragma warning restore CS1591
        [EnumMember(Value = "google")]
        #pragma warning disable CS1591
        Google,
        #pragma warning restore CS1591
        [EnumMember(Value = "lets_encrypt")]
        #pragma warning disable CS1591
        Lets_encrypt,
        #pragma warning restore CS1591
        [EnumMember(Value = "ssl_com")]
        #pragma warning disable CS1591
        Ssl_com,
        #pragma warning restore CS1591
    }
}
