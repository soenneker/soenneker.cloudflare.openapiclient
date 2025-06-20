// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>Defines the mode/action of the rule when triggered. You must use a value from the `allowed_modes` array of the current rule.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Waf_rules_update_a_waf_rule_mode
    {
        [EnumMember(Value = "default")]
        #pragma warning disable CS1591
        Default,
        #pragma warning restore CS1591
        [EnumMember(Value = "disable")]
        #pragma warning disable CS1591
        Disable,
        #pragma warning restore CS1591
        [EnumMember(Value = "simulate")]
        #pragma warning disable CS1591
        Simulate,
        #pragma warning restore CS1591
        [EnumMember(Value = "block")]
        #pragma warning disable CS1591
        Block,
        #pragma warning restore CS1591
        [EnumMember(Value = "challenge")]
        #pragma warning disable CS1591
        Challenge,
        #pragma warning restore CS1591
        [EnumMember(Value = "on")]
        #pragma warning disable CS1591
        On,
        #pragma warning restore CS1591
        [EnumMember(Value = "off")]
        #pragma warning disable CS1591
        Off,
        #pragma warning restore CS1591
    }
}
