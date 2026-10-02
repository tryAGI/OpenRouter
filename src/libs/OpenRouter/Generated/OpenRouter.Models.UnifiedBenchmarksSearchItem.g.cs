
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedBenchmarksSearchItem
    {
        /// <summary>
        /// Average cost per task in USD, or null if unavailable.<br/>
        /// Example: 0.031F
        /// </summary>
        /// <example>0.031F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_cost_per_task")]
        public double? AvgCostPerTask { get; set; }

        /// <summary>
        /// Average wall-clock latency per task in milliseconds, or null if unavailable.<br/>
        /// Example: 45210
        /// </summary>
        /// <example>45210</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_latency_per_task_ms")]
        public double? AvgLatencyPerTaskMs { get; set; }

        /// <summary>
        /// OpenRouter search benchmark.<br/>
        /// Example: search_browsecomp
        /// </summary>
        /// <example>search_browsecomp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("benchmark_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksSearchItemBenchmarkTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksSearchItemBenchmarkType BenchmarkType { get; set; }

        /// <summary>
        /// Human-readable model name.<br/>
        /// Example: GPT-4o
        /// </summary>
        /// <example>GPT-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Timestamp of the newest qualifying run in the published configuration's lane.<br/>
        /// Example: 2026-07-28T13:38:18Z
        /// </summary>
        /// <example>2026-07-28T13:38:18Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastRunTimestamp { get; set; }

        /// <summary>
        /// Stable OpenRouter model identifier.<br/>
        /// Example: openai/gpt-4o
        /// </summary>
        /// <example>openai/gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Identifies the meaning of `primary_score`: `f1_by_item` for WideSearch, `accuracy` for all other search benchmarks.<br/>
        /// Example: accuracy
        /// </summary>
        /// <example>accuracy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksSearchItemPrimaryMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksSearchItemPrimaryMetric PrimaryMetric { get; set; }

        /// <summary>
        /// The benchmark's headline score from 0 to 1. Its meaning is identified by `primary_metric`: item-weighted F1 for WideSearch or strict accuracy for the other search benchmarks. Higher is better.<br/>
        /// Example: 0.72F
        /// </summary>
        /// <example>0.72F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PrimaryScore { get; set; }

        /// <summary>
        /// Published lane configuration, included only when include_run_config=true. Only the agent turn count, reasoning effort, and temperature are exposed; other harness settings are intentionally not part of the public contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_config")]
        public global::OpenRouter.UnifiedBenchmarksSearchRunConfig? RunConfig { get; set; }

        /// <summary>
        /// Search engine the published configuration used.<br/>
        /// Example: exa
        /// </summary>
        /// <example>exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_engine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchEngine { get; set; }

        /// <summary>
        /// Request surface the published configuration went through.<br/>
        /// Example: server-tool
        /// </summary>
        /// <example>server-tool</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_surface")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksSearchItemSearchSurfaceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksSearchItemSearchSurface SearchSurface { get; set; }

        /// <summary>
        /// Benchmark source discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksSearchItemSourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksSearchItemSource Source { get; set; }

        /// <summary>
        /// Tasks evaluated across the published configuration's runs.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksSearchItem" /> class.
        /// </summary>
        /// <param name="benchmarkType">
        /// OpenRouter search benchmark.<br/>
        /// Example: search_browsecomp
        /// </param>
        /// <param name="displayName">
        /// Human-readable model name.<br/>
        /// Example: GPT-4o
        /// </param>
        /// <param name="lastRunTimestamp">
        /// Timestamp of the newest qualifying run in the published configuration's lane.<br/>
        /// Example: 2026-07-28T13:38:18Z
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier.<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="primaryMetric">
        /// Identifies the meaning of `primary_score`: `f1_by_item` for WideSearch, `accuracy` for all other search benchmarks.<br/>
        /// Example: accuracy
        /// </param>
        /// <param name="primaryScore">
        /// The benchmark's headline score from 0 to 1. Its meaning is identified by `primary_metric`: item-weighted F1 for WideSearch or strict accuracy for the other search benchmarks. Higher is better.<br/>
        /// Example: 0.72F
        /// </param>
        /// <param name="searchEngine">
        /// Search engine the published configuration used.<br/>
        /// Example: exa
        /// </param>
        /// <param name="searchSurface">
        /// Request surface the published configuration went through.<br/>
        /// Example: server-tool
        /// </param>
        /// <param name="totalTasks">
        /// Tasks evaluated across the published configuration's runs.<br/>
        /// Example: 100
        /// </param>
        /// <param name="avgCostPerTask">
        /// Average cost per task in USD, or null if unavailable.<br/>
        /// Example: 0.031F
        /// </param>
        /// <param name="avgLatencyPerTaskMs">
        /// Average wall-clock latency per task in milliseconds, or null if unavailable.<br/>
        /// Example: 45210
        /// </param>
        /// <param name="runConfig">
        /// Published lane configuration, included only when include_run_config=true. Only the agent turn count, reasoning effort, and temperature are exposed; other harness settings are intentionally not part of the public contract.
        /// </param>
        /// <param name="source">
        /// Benchmark source discriminator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksSearchItem(
            global::OpenRouter.UnifiedBenchmarksSearchItemBenchmarkType benchmarkType,
            string displayName,
            string lastRunTimestamp,
            string modelPermaslug,
            global::OpenRouter.UnifiedBenchmarksSearchItemPrimaryMetric primaryMetric,
            double primaryScore,
            string searchEngine,
            global::OpenRouter.UnifiedBenchmarksSearchItemSearchSurface searchSurface,
            int totalTasks,
            double? avgCostPerTask,
            double? avgLatencyPerTaskMs,
            global::OpenRouter.UnifiedBenchmarksSearchRunConfig? runConfig,
            global::OpenRouter.UnifiedBenchmarksSearchItemSource source)
        {
            this.AvgCostPerTask = avgCostPerTask;
            this.AvgLatencyPerTaskMs = avgLatencyPerTaskMs;
            this.BenchmarkType = benchmarkType;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.LastRunTimestamp = lastRunTimestamp ?? throw new global::System.ArgumentNullException(nameof(lastRunTimestamp));
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.PrimaryMetric = primaryMetric;
            this.PrimaryScore = primaryScore;
            this.RunConfig = runConfig;
            this.SearchEngine = searchEngine ?? throw new global::System.ArgumentNullException(nameof(searchEngine));
            this.SearchSurface = searchSurface;
            this.Source = source;
            this.TotalTasks = totalTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksSearchItem" /> class.
        /// </summary>
        public UnifiedBenchmarksSearchItem()
        {
        }

    }
}