
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BenchmarksAAItem
    {
        /// <summary>
        /// Model name as listed on Artificial Analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aa_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AaName { get; set; }

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
        public required global::OpenRouter.BenchmarkPricing Pricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksAAItem" /> class.
        /// </summary>
        /// <param name="aaName">
        /// Model name as listed on Artificial Analysis.
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier.
        /// </param>
        /// <param name="pricing">
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.
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
        public BenchmarksAAItem(
            string aaName,
            string modelPermaslug,
            global::OpenRouter.BenchmarkPricing pricing,
            double? agenticIndex,
            double? codingIndex,
            double? intelligenceIndex)
        {
            this.AaName = aaName ?? throw new global::System.ArgumentNullException(nameof(aaName));
            this.AgenticIndex = agenticIndex;
            this.CodingIndex = codingIndex;
            this.IntelligenceIndex = intelligenceIndex;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksAAItem" /> class.
        /// </summary>
        public BenchmarksAAItem()
        {
        }

    }
}