
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAnalyticsRequestOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.QueryAnalyticsRequestOrderByDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.QueryAnalyticsRequestOrderByDirection Direction { get; set; }

        /// <summary>
        /// Field to order by: a metric included in `metrics` (or "request_count", which may be ordered by without being requested), a requested dimension, or "date".<br/>
        /// Example: request_count
        /// </summary>
        /// <example>request_count</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestOrderBy" /> class.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="field">
        /// Field to order by: a metric included in `metrics` (or "request_count", which may be ordered by without being requested), a requested dimension, or "date".<br/>
        /// Example: request_count
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAnalyticsRequestOrderBy(
            global::OpenRouter.QueryAnalyticsRequestOrderByDirection direction,
            string field)
        {
            this.Direction = direction;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestOrderBy" /> class.
        /// </summary>
        public QueryAnalyticsRequestOrderBy()
        {
        }

    }
}