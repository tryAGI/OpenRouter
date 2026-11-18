
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"as_of":"2026-06-03T12:00:00Z","citation":"Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).","model_count":50,"source":"artificial-analysis","source_url":"https://artificialanalysis.ai","task_type":null,"version":"v1"}
    /// </summary>
    public sealed partial class UnifiedBenchmarksMeta
    {
        /// <summary>
        /// ISO-8601 timestamp of when this data was last updated.<br/>
        /// Example: 2026-06-03T12:00:00Z
        /// </summary>
        /// <example>2026-06-03T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AsOf { get; set; }

        /// <summary>
        /// Required attribution when republishing this data. Always set when `source` is set. When `source` is null, set if every returned item comes from one source, and null if the items span sources (attribute each item by its `source` discriminator) or there are none.<br/>
        /// Example: Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).
        /// </summary>
        /// <example>Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        public string? Citation { get; set; }

        /// <summary>
        /// Number of unique models in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelCount { get; set; }

        /// <summary>
        /// The one source the response is limited to: the `source` filter, or Artificial Analysis for a `task_type` only it answers. Null when the response draws on every source.<br/>
        /// Example: artificial-analysis
        /// </summary>
        /// <example>artificial-analysis</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaSourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksMetaSource? Source { get; set; }

        /// <summary>
        /// URL of the upstream data source. Always set when `source` is set. When `source` is null, set if every returned item comes from one source, and null if the items span sources or there are none.<br/>
        /// Example: https://artificialanalysis.ai
        /// </summary>
        /// <example>https://artificialanalysis.ai</example>
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
        /// ISO-8601 timestamp of when this data was last updated.<br/>
        /// Example: 2026-06-03T12:00:00Z
        /// </param>
        /// <param name="modelCount">
        /// Number of unique models in the response.
        /// </param>
        /// <param name="citation">
        /// Required attribution when republishing this data. Always set when `source` is set. When `source` is null, set if every returned item comes from one source, and null if the items span sources (attribute each item by its `source` discriminator) or there are none.<br/>
        /// Example: Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).
        /// </param>
        /// <param name="source">
        /// The one source the response is limited to: the `source` filter, or Artificial Analysis for a `task_type` only it answers. Null when the response draws on every source.<br/>
        /// Example: artificial-analysis
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the upstream data source. Always set when `source` is set. When `source` is null, set if every returned item comes from one source, and null if the items span sources or there are none.<br/>
        /// Example: https://artificialanalysis.ai
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
            string? citation,
            global::OpenRouter.UnifiedBenchmarksMetaSource? source,
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