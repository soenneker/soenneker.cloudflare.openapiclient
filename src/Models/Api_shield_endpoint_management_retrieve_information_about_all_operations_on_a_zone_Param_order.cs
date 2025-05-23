// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    /// <summary>Field to order by. When requesting a feature, the feature keys are available for ordering as well, e.g., `thresholds.suggested_threshold`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Api_shield_endpoint_management_retrieve_information_about_all_operations_on_a_zone_Param_order
    {
        [EnumMember(Value = "method")]
        #pragma warning disable CS1591
        Method,
        #pragma warning restore CS1591
        [EnumMember(Value = "host")]
        #pragma warning disable CS1591
        Host,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpoint")]
        #pragma warning disable CS1591
        Endpoint,
        #pragma warning restore CS1591
        [EnumMember(Value = "thresholds.$key")]
        #pragma warning disable CS1591
        ThresholdsKey,
        #pragma warning restore CS1591
    }
}
