
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAnalyticsRequest
    {
        /// <summary>
        /// Group results by custom classifier tags, breaking down metrics by the specified dimension values. Requires an active classifier on the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_dimensions")]
        public global::OpenRouter.QueryAnalyticsRequestClassifierDimensions? ClassifierDimensions { get; set; }

        /// <summary>
        /// Filter results to generations with specific classifier tag values. Can be combined with classifier_dimensions (must use the same classifier_id) or used independently with standard dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_filters")]
        public global::OpenRouter.QueryAnalyticsRequestClassifierFilters? ClassifierFilters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.IList<string>? Dimensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.QueryAnalyticsRequestFilter>? Filters { get; set; }

        /// <summary>
        /// Time granularity<br/>
        /// Example: day
        /// </summary>
        /// <example>day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public string? Granularity { get; set; }

        /// <summary>
        /// Maximum rows per distinct combination of dimensions. When omitted on time-series queries (granularity + dimensions), auto-computed to avoid truncating time windows. Explicit values override the default and may truncate time buckets if set lower than the number of buckets in the range. Ignored when no dimensions are specified.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_limit")]
        public int? GroupLimit { get; set; }

        /// <summary>
        /// Maximum total rows returned. Defaults to 1000. On time-series queries with dimensions and no explicit group_limit, the server may raise this to accommodate the expected number of unique time-bucket/dimension combinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public global::OpenRouter.QueryAnalyticsRequestOrderBy? OrderBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public global::OpenRouter.QueryAnalyticsRequestTimeRange? TimeRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequest" /> class.
        /// </summary>
        /// <param name="metrics"></param>
        /// <param name="classifierDimensions">
        /// Group results by custom classifier tags, breaking down metrics by the specified dimension values. Requires an active classifier on the workspace.
        /// </param>
        /// <param name="classifierFilters">
        /// Filter results to generations with specific classifier tag values. Can be combined with classifier_dimensions (must use the same classifier_id) or used independently with standard dimensions.
        /// </param>
        /// <param name="dimensions"></param>
        /// <param name="filters"></param>
        /// <param name="granularity">
        /// Time granularity<br/>
        /// Example: day
        /// </param>
        /// <param name="groupLimit">
        /// Maximum rows per distinct combination of dimensions. When omitted on time-series queries (granularity + dimensions), auto-computed to avoid truncating time windows. Explicit values override the default and may truncate time buckets if set lower than the number of buckets in the range. Ignored when no dimensions are specified.<br/>
        /// Example: 100
        /// </param>
        /// <param name="limit">
        /// Maximum total rows returned. Defaults to 1000. On time-series queries with dimensions and no explicit group_limit, the server may raise this to accommodate the expected number of unique time-bucket/dimension combinations.
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="timeRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAnalyticsRequest(
            global::System.Collections.Generic.IList<string> metrics,
            global::OpenRouter.QueryAnalyticsRequestClassifierDimensions? classifierDimensions,
            global::OpenRouter.QueryAnalyticsRequestClassifierFilters? classifierFilters,
            global::System.Collections.Generic.IList<string>? dimensions,
            global::System.Collections.Generic.IList<global::OpenRouter.QueryAnalyticsRequestFilter>? filters,
            string? granularity,
            int? groupLimit,
            int? limit,
            global::OpenRouter.QueryAnalyticsRequestOrderBy? orderBy,
            global::OpenRouter.QueryAnalyticsRequestTimeRange? timeRange)
        {
            this.ClassifierDimensions = classifierDimensions;
            this.ClassifierFilters = classifierFilters;
            this.Dimensions = dimensions;
            this.Filters = filters;
            this.Granularity = granularity;
            this.GroupLimit = groupLimit;
            this.Limit = limit;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.OrderBy = orderBy;
            this.TimeRange = timeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequest" /> class.
        /// </summary>
        public QueryAnalyticsRequest()
        {
        }

    }
}