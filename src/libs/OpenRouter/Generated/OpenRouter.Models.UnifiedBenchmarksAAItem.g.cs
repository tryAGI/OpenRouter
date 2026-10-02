
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"agentic_index":58.3,"coding_index":65.8,"display_name":"GPT-4o","intelligence_index":71.2,"model_permaslug":"openai/gpt-4o","pricing":{"completion":"0.00001","prompt":"0.0000025"},"source":"artificial-analysis"}
    /// </summary>
    public sealed partial class UnifiedBenchmarksAAItem
    {
        /// <summary>
        /// Artificial Analysis Agentic Index composite score. Higher is better.<br/>
        /// Example: 58.3F
        /// </summary>
        /// <example>58.3F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_index")]
        public double? AgenticIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Coding Index composite score. Higher is better.<br/>
        /// Example: 65.8F
        /// </summary>
        /// <example>65.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coding_index")]
        public double? CodingIndex { get; set; }

        /// <summary>
        /// Model name as listed on Artificial Analysis.<br/>
        /// Example: GPT-4o
        /// </summary>
        /// <example>GPT-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Artificial Analysis Intelligence Index composite score. Higher is better.<br/>
        /// Example: 71.2F
        /// </summary>
        /// <example>71.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence_index")]
        public double? IntelligenceIndex { get; set; }

        /// <summary>
        /// Stable OpenRouter model identifier.<br/>
        /// Example: openai/gpt-4o
        /// </summary>
        /// <example>openai/gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.<br/>
        /// Example: {"completion":"0.000015","prompt":"0.000003"}
        /// </summary>
        /// <example>{"completion":"0.000015","prompt":"0.000003"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::OpenRouter.UnifiedBenchmarkPricing? Pricing { get; set; }

        /// <summary>
        /// Benchmark source discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksAAItemSourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksAAItemSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksAAItem" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Model name as listed on Artificial Analysis.<br/>
        /// Example: GPT-4o
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier.<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="agenticIndex">
        /// Artificial Analysis Agentic Index composite score. Higher is better.<br/>
        /// Example: 58.3F
        /// </param>
        /// <param name="codingIndex">
        /// Artificial Analysis Coding Index composite score. Higher is better.<br/>
        /// Example: 65.8F
        /// </param>
        /// <param name="intelligenceIndex">
        /// Artificial Analysis Intelligence Index composite score. Higher is better.<br/>
        /// Example: 71.2F
        /// </param>
        /// <param name="pricing">
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.<br/>
        /// Example: {"completion":"0.000015","prompt":"0.000003"}
        /// </param>
        /// <param name="source">
        /// Benchmark source discriminator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksAAItem(
            string displayName,
            string modelPermaslug,
            double? agenticIndex,
            double? codingIndex,
            double? intelligenceIndex,
            global::OpenRouter.UnifiedBenchmarkPricing? pricing,
            global::OpenRouter.UnifiedBenchmarksAAItemSource source)
        {
            this.AgenticIndex = agenticIndex;
            this.CodingIndex = codingIndex;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IntelligenceIndex = intelligenceIndex;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksAAItem" /> class.
        /// </summary>
        public UnifiedBenchmarksAAItem()
        {
        }

    }
}