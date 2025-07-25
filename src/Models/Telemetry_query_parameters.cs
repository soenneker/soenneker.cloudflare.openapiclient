// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Cloudflare.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Telemetry_query_parameters : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Create Calculations to compute as part of the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_calculations>? Calculations { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_calculations> Calculations { get; set; }
#endif
        /// <summary>Set the Datasets to query. Leave it empty to query all the datasets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Datasets { get; set; }
#nullable restore
#else
        public List<string> Datasets { get; set; }
#endif
        /// <summary>Set a Flag to describe how to combine the filters on the query.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filterCombination? FilterCombination { get; set; }
        /// <summary>Configure the Filters to apply to the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filters>? Filters { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filters> Filters { get; set; }
#endif
        /// <summary>Define how to group the results of the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_groupBys>? GroupBys { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_groupBys> GroupBys { get; set; }
#endif
        /// <summary>Configure the Having clauses that filter on calculations in the query result.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_havings>? Havings { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_havings> Havings { get; set; }
#endif
        /// <summary>Set a limit on the number of results / records returned by the query</summary>
        public int? Limit { get; set; }
        /// <summary>Define an expression to search using full-text search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_needle? Needle { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_needle Needle { get; set; }
#endif
        /// <summary>Configure the order of the results returned by the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_orderBy? OrderBy { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_orderBy OrderBy { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters"/> and sets the default values.
        /// </summary>
        public Telemetry_query_parameters()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "calculations", n => { Calculations = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_calculations>(global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_calculations.CreateFromDiscriminatorValue)?.AsList(); } },
                { "datasets", n => { Datasets = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "filterCombination", n => { FilterCombination = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filterCombination>(); } },
                { "filters", n => { Filters = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filters>(global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filters.CreateFromDiscriminatorValue)?.AsList(); } },
                { "groupBys", n => { GroupBys = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_groupBys>(global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_groupBys.CreateFromDiscriminatorValue)?.AsList(); } },
                { "havings", n => { Havings = n.GetCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_havings>(global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_havings.CreateFromDiscriminatorValue)?.AsList(); } },
                { "limit", n => { Limit = n.GetIntValue(); } },
                { "needle", n => { Needle = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_needle>(global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_needle.CreateFromDiscriminatorValue); } },
                { "orderBy", n => { OrderBy = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_orderBy>(global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_orderBy.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_calculations>("calculations", Calculations);
            writer.WriteCollectionOfPrimitiveValues<string>("datasets", Datasets);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filterCombination>("filterCombination", FilterCombination);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_filters>("filters", Filters);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_groupBys>("groupBys", GroupBys);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_havings>("havings", Havings);
            writer.WriteIntValue("limit", Limit);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_needle>("needle", Needle);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.Telemetry_query_parameters_orderBy>("orderBy", OrderBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
