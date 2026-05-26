
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankingsDailyMeta
    {
        /// <summary>
        /// ISO-8601 timestamp of when the response was generated. Reflects data-freshness because the underlying materialized view continuously ingests upstream events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AsOf { get; set; }

        /// <summary>
        /// Resolved end of the date window (UTC, inclusive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// Resolved start of the date window (UTC, inclusive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDate { get; set; }

        /// <summary>
        /// Dataset version. Field names and grain are stable for the life of `v1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RankingsDailyMetaVersionJsonConverter))]
        public global::OpenRouter.RankingsDailyMetaVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsDailyMeta" /> class.
        /// </summary>
        /// <param name="asOf">
        /// ISO-8601 timestamp of when the response was generated. Reflects data-freshness because the underlying materialized view continuously ingests upstream events.
        /// </param>
        /// <param name="endDate">
        /// Resolved end of the date window (UTC, inclusive).
        /// </param>
        /// <param name="startDate">
        /// Resolved start of the date window (UTC, inclusive).
        /// </param>
        /// <param name="version">
        /// Dataset version. Field names and grain are stable for the life of `v1`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankingsDailyMeta(
            string asOf,
            string endDate,
            string startDate,
            global::OpenRouter.RankingsDailyMetaVersion version)
        {
            this.AsOf = asOf ?? throw new global::System.ArgumentNullException(nameof(asOf));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsDailyMeta" /> class.
        /// </summary>
        public RankingsDailyMeta()
        {
        }

    }
}