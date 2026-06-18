
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// artificial-analysis variant
    /// </summary>
    public sealed partial class UnifiedBenchmarksResponseDataItemsVariant1
    {
        /// <summary>
        /// Discriminator value: artificial-analysis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsVariant1SourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source Source { get; set; }

        /// <summary>
        /// Artificial Analysis Agentic Index composite score. Higher is better.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_index")]
        public double? AgenticIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Coding Index composite score. Higher is better.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coding_index")]
        public double? CodingIndex { get; set; }

        /// <summary>
        /// Model name as listed on Artificial Analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Artificial Analysis Intelligence Index composite score. Higher is better.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence_index")]
        public double? IntelligenceIndex { get; set; }

        /// <summary>
        /// Stable OpenRouter model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarkPricing Pricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksResponseDataItemsVariant1" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Model name as listed on Artificial Analysis.
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier.
        /// </param>
        /// <param name="pricing">
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.
        /// </param>
        /// <param name="source">
        /// Discriminator value: artificial-analysis
        /// </param>
        /// <param name="agenticIndex">
        /// Artificial Analysis Agentic Index composite score. Higher is better.
        /// </param>
        /// <param name="codingIndex">
        /// Artificial Analysis Coding Index composite score. Higher is better.
        /// </param>
        /// <param name="intelligenceIndex">
        /// Artificial Analysis Intelligence Index composite score. Higher is better.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksResponseDataItemsVariant1(
            string displayName,
            string modelPermaslug,
            global::OpenRouter.UnifiedBenchmarkPricing pricing,
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source source,
            double? agenticIndex,
            double? codingIndex,
            double? intelligenceIndex)
        {
            this.Source = source;
            this.AgenticIndex = agenticIndex;
            this.CodingIndex = codingIndex;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IntelligenceIndex = intelligenceIndex;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksResponseDataItemsVariant1" /> class.
        /// </summary>
        public UnifiedBenchmarksResponseDataItemsVariant1()
        {
        }

    }
}