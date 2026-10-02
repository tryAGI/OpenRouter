
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"accuracy":0.72,"accuracy_stddev":0.03,"avg_cost_per_task":0.002,"benchmark_type":"gpqa_diamond","display_name":"GPT-4o","last_run_timestamp":"2026-06-03T12:00:00Z","model_permaslug":"openai/gpt-4o","source":"openrouter","total_tasks":300}
    /// </summary>
    public sealed partial class UnifiedBenchmarksORItem
    {
        /// <summary>
        /// Aggregate accuracy score from 0 to 1. Higher is better.<br/>
        /// Example: 0.72F
        /// </summary>
        /// <example>0.72F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Accuracy { get; set; }

        /// <summary>
        /// Standard deviation of run accuracy, or null for a single run.<br/>
        /// Example: 0.03F
        /// </summary>
        /// <example>0.03F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracy_stddev")]
        public double? AccuracyStddev { get; set; }

        /// <summary>
        /// Average cost per task in USD, or null if unavailable.<br/>
        /// Example: 0.002F
        /// </summary>
        /// <example>0.002F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_cost_per_task")]
        public double? AvgCostPerTask { get; set; }

        /// <summary>
        /// OpenRouter benchmark evaluation type.<br/>
        /// Example: gpqa_diamond
        /// </summary>
        /// <example>gpqa_diamond</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("benchmark_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksORItemBenchmarkTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksORItemBenchmarkType BenchmarkType { get; set; }

        /// <summary>
        /// Human-readable model name.<br/>
        /// Example: GPT-4o
        /// </summary>
        /// <example>GPT-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Timestamp of the most recent public benchmark run.<br/>
        /// Example: 2026-06-03T12:00:00Z
        /// </summary>
        /// <example>2026-06-03T12:00:00Z</example>
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
        /// Benchmark source discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksORItemSourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksORItemSource Source { get; set; }

        /// <summary>
        /// Total benchmark tasks across runs.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksORItem" /> class.
        /// </summary>
        /// <param name="accuracy">
        /// Aggregate accuracy score from 0 to 1. Higher is better.<br/>
        /// Example: 0.72F
        /// </param>
        /// <param name="benchmarkType">
        /// OpenRouter benchmark evaluation type.<br/>
        /// Example: gpqa_diamond
        /// </param>
        /// <param name="displayName">
        /// Human-readable model name.<br/>
        /// Example: GPT-4o
        /// </param>
        /// <param name="lastRunTimestamp">
        /// Timestamp of the most recent public benchmark run.<br/>
        /// Example: 2026-06-03T12:00:00Z
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier.<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="totalTasks">
        /// Total benchmark tasks across runs.<br/>
        /// Example: 300
        /// </param>
        /// <param name="accuracyStddev">
        /// Standard deviation of run accuracy, or null for a single run.<br/>
        /// Example: 0.03F
        /// </param>
        /// <param name="avgCostPerTask">
        /// Average cost per task in USD, or null if unavailable.<br/>
        /// Example: 0.002F
        /// </param>
        /// <param name="source">
        /// Benchmark source discriminator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksORItem(
            double accuracy,
            global::OpenRouter.UnifiedBenchmarksORItemBenchmarkType benchmarkType,
            string displayName,
            string lastRunTimestamp,
            string modelPermaslug,
            int totalTasks,
            double? accuracyStddev,
            double? avgCostPerTask,
            global::OpenRouter.UnifiedBenchmarksORItemSource source)
        {
            this.Accuracy = accuracy;
            this.AccuracyStddev = accuracyStddev;
            this.AvgCostPerTask = avgCostPerTask;
            this.BenchmarkType = benchmarkType;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.LastRunTimestamp = lastRunTimestamp ?? throw new global::System.ArgumentNullException(nameof(lastRunTimestamp));
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Source = source;
            this.TotalTasks = totalTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksORItem" /> class.
        /// </summary>
        public UnifiedBenchmarksORItem()
        {
        }

    }
}