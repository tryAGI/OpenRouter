
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"agentic_index":58.3,"coding_index":65.8,"display_name":"GPT-4o","intelligence_index":71.2,"model_permaslug":"openai/gpt-4o","pricing":{"completion":"0.00001","prompt":"0.0000025"},"source":"artificial-analysis"},{"accuracy":0.72,"accuracy_stddev":0.03,"avg_cost_per_task":0.002,"benchmark_type":"gpqa_diamond","display_name":"GPT-4o","last_run_timestamp":"2026-06-03T12:00:00Z","model_permaslug":"openai/gpt-4o","source":"openrouter","total_tasks":300}],"meta":{"as_of":"2026-06-03T12:00:00Z","citation":null,"model_count":1,"source":null,"source_url":null,"task_type":null,"version":"v1"}}
    /// </summary>
    public sealed partial class UnifiedBenchmarksResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>> Data { get; set; }

        /// <summary>
        /// Example: {"as_of":"2026-06-03T12:00:00Z","citation":"Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).","model_count":50,"source":"artificial-analysis","source_url":"https://artificialanalysis.ai","task_type":null,"version":"v1"}
        /// </summary>
        /// <example>{"as_of":"2026-06-03T12:00:00Z","citation":"Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).","model_count":50,"source":"artificial-analysis","source_url":"https://artificialanalysis.ai","task_type":null,"version":"v1"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta">
        /// Example: {"as_of":"2026-06-03T12:00:00Z","citation":"Source: Artificial Analysis (artificialanalysis.ai) via OpenRouter (openrouter.ai/rankings).","model_count":50,"source":"artificial-analysis","source_url":"https://artificialanalysis.ai","task_type":null,"version":"v1"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>> data,
            global::OpenRouter.UnifiedBenchmarksMeta meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksResponse" /> class.
        /// </summary>
        public UnifiedBenchmarksResponse()
        {
        }

    }
}