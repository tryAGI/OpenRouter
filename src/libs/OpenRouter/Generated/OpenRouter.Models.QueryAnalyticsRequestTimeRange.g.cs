
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAnalyticsRequestTimeRange
    {
        /// <summary>
        /// ISO 8601 UTC timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </summary>
        /// <example>2027-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// ISO 8601 UTC timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </summary>
        /// <example>2027-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestTimeRange" /> class.
        /// </summary>
        /// <param name="end">
        /// ISO 8601 UTC timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
        /// <param name="start">
        /// ISO 8601 UTC timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAnalyticsRequestTimeRange(
            global::System.DateTime end,
            global::System.DateTime start)
        {
            this.End = end;
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestTimeRange" /> class.
        /// </summary>
        public QueryAnalyticsRequestTimeRange()
        {
        }

    }
}