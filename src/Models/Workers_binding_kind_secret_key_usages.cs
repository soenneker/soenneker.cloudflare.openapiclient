// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum Workers_binding_kind_secret_key_usages
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "encrypt")]
        #pragma warning disable CS1591
        Encrypt,
        #pragma warning restore CS1591
        [EnumMember(Value = "decrypt")]
        #pragma warning disable CS1591
        Decrypt,
        #pragma warning restore CS1591
        [EnumMember(Value = "sign")]
        #pragma warning disable CS1591
        Sign,
        #pragma warning restore CS1591
        [EnumMember(Value = "verify")]
        #pragma warning disable CS1591
        Verify,
        #pragma warning restore CS1591
        [EnumMember(Value = "deriveKey")]
        #pragma warning disable CS1591
        DeriveKey,
        #pragma warning restore CS1591
        [EnumMember(Value = "deriveBits")]
        #pragma warning disable CS1591
        DeriveBits,
        #pragma warning restore CS1591
        [EnumMember(Value = "wrapKey")]
        #pragma warning disable CS1591
        WrapKey,
        #pragma warning restore CS1591
        [EnumMember(Value = "unwrapKey")]
        #pragma warning disable CS1591
        UnwrapKey,
        #pragma warning restore CS1591
    }
}
