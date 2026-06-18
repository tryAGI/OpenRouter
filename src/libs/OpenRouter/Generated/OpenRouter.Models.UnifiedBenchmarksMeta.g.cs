
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
        /// Required attribution when republishing this data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Citation { get; set; }

        /// <summary>
        /// Number of unique models in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelCount { get; set; }

        /// <summary>
        /// The source filter applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksMetaSource Source { get; set; }

        /// <summary>
        /// URL of the upstream data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceUrl { get; set; }

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
        /// <param name="citation">
        /// Required attribution when republishing this data.
        /// </param>
        /// <param name="modelCount">
        /// Number of unique models in the response.
        /// </param>
        /// <param name="source">
        /// The source filter applied.
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the upstream data source.
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
            string citation,
            int modelCount,
            global::OpenRouter.UnifiedBenchmarksMetaSource source,
            string sourceUrl,
            string? taskType,
            global::OpenRouter.UnifiedBenchmarksMetaVersion version)
        {
            this.AsOf = asOf ?? throw new global::System.ArgumentNullException(nameof(asOf));
            this.Citation = citation ?? throw new global::System.ArgumentNullException(nameof(citation));
            this.ModelCount = modelCount;
            this.Source = source;
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
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