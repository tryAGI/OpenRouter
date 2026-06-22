
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnifiedBenchmarksMeta
    {
        /// <summary>
        /// ISO-8601 timestamp of when this data was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AsOf { get; set; }

        /// <summary>
        /// Required attribution when republishing this data, or null when results span multiple sources (attribute each item individually by its `source` discriminator).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        public string? Citation { get; set; }

        /// <summary>
        /// Number of unique models in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelCount { get; set; }

        /// <summary>
        /// The source filter applied, or null when all sources are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.UnifiedBenchmarksMetaSource?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksMetaSource?, object> Source { get; set; }

        /// <summary>
        /// URL of the upstream data source, or null when results span multiple sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// The task_type filter applied, or null if showing all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_type")]
        public string? TaskType { get; set; }

        /// <summary>
        /// Dataset version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaVersionJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksMetaVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksMeta" /> class.
        /// </summary>
        /// <param name="asOf">
        /// ISO-8601 timestamp of when this data was last updated.
        /// </param>
        /// <param name="modelCount">
        /// Number of unique models in the response.
        /// </param>
        /// <param name="source">
        /// The source filter applied, or null when all sources are returned.
        /// </param>
        /// <param name="citation">
        /// Required attribution when republishing this data, or null when results span multiple sources (attribute each item individually by its `source` discriminator).
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the upstream data source, or null when results span multiple sources.
        /// </param>
        /// <param name="taskType">
        /// The task_type filter applied, or null if showing all.
        /// </param>
        /// <param name="version">
        /// Dataset version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksMeta(
            string asOf,
            int modelCount,
            global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksMetaSource?, object> source,
            string? citation,
            string? sourceUrl,
            string? taskType,
            global::OpenRouter.UnifiedBenchmarksMetaVersion version)
        {
            this.AsOf = asOf ?? throw new global::System.ArgumentNullException(nameof(asOf));
            this.Citation = citation;
            this.ModelCount = modelCount;
            this.Source = source;
            this.SourceUrl = sourceUrl;
            this.TaskType = taskType;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksMeta" /> class.
        /// </summary>
        public UnifiedBenchmarksMeta()
        {
        }

    }
}