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
    public partial class D1_queryMeta : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Denotes if the database has been altered in some way, like deleting rows.</summary>
        public bool? ChangedDb { get; set; }
        /// <summary>Rough indication of how many rows were modified by the query, as provided by SQLite&apos;s `sqlite3_total_changes()`.</summary>
        public double? Changes { get; set; }
        /// <summary>The duration of the SQL query execution inside the database. Does not include any network communication.</summary>
        public double? Duration { get; set; }
        /// <summary>The row ID of the last inserted row in a table with an `INTEGER PRIMARY KEY` as provided by SQLite. Tables created with `WITHOUT ROWID` do not populate this.</summary>
        public double? LastRowId { get; set; }
        /// <summary>Number of rows read during the SQL query execution, including indices (not all rows are necessarily returned).</summary>
        public double? RowsRead { get; set; }
        /// <summary>Number of rows written during the SQL query execution, including indices.</summary>
        public double? RowsWritten { get; set; }
        /// <summary>Denotes if the query has been handled by the database primary instance.</summary>
        public bool? ServedByPrimary { get; set; }
        /// <summary>Region location hint of the database instance that handled the query.</summary>
        public global::Soenneker.Cloudflare.OpenApiClient.Models.D1_servedByRegion? ServedByRegion { get; set; }
        /// <summary>Size of the database after the query committed, in bytes.</summary>
        public double? SizeAfter { get; set; }
        /// <summary>Various durations for the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta_timings? Timings { get; set; }
#nullable restore
#else
        public global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta_timings Timings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta"/> and sets the default values.
        /// </summary>
        public D1_queryMeta()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "changed_db", n => { ChangedDb = n.GetBoolValue(); } },
                { "changes", n => { Changes = n.GetDoubleValue(); } },
                { "duration", n => { Duration = n.GetDoubleValue(); } },
                { "last_row_id", n => { LastRowId = n.GetDoubleValue(); } },
                { "rows_read", n => { RowsRead = n.GetDoubleValue(); } },
                { "rows_written", n => { RowsWritten = n.GetDoubleValue(); } },
                { "served_by_primary", n => { ServedByPrimary = n.GetBoolValue(); } },
                { "served_by_region", n => { ServedByRegion = n.GetEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.D1_servedByRegion>(); } },
                { "size_after", n => { SizeAfter = n.GetDoubleValue(); } },
                { "timings", n => { Timings = n.GetObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta_timings>(global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta_timings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("changed_db", ChangedDb);
            writer.WriteDoubleValue("changes", Changes);
            writer.WriteDoubleValue("duration", Duration);
            writer.WriteDoubleValue("last_row_id", LastRowId);
            writer.WriteDoubleValue("rows_read", RowsRead);
            writer.WriteDoubleValue("rows_written", RowsWritten);
            writer.WriteBoolValue("served_by_primary", ServedByPrimary);
            writer.WriteEnumValue<global::Soenneker.Cloudflare.OpenApiClient.Models.D1_servedByRegion>("served_by_region", ServedByRegion);
            writer.WriteDoubleValue("size_after", SizeAfter);
            writer.WriteObjectValue<global::Soenneker.Cloudflare.OpenApiClient.Models.D1_queryMeta_timings>("timings", Timings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
