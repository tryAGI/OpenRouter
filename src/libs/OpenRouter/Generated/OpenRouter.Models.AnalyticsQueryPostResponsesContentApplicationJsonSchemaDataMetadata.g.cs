
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double QueryTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata" /> class.
        /// </summary>
        /// <param name="queryTimeMs"></param>
        /// <param name="rowCount"></param>
        /// <param name="truncated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata(
            double queryTimeMs,
            int rowCount,
            bool truncated)
        {
            this.QueryTimeMs = queryTimeMs;
            this.RowCount = rowCount;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata" /> class.
        /// </summary>
        public AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata()
        {
        }

    }
}