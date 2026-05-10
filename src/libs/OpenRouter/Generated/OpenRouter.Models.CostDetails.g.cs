
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Breakdown of upstream inference costs
    /// </summary>
    public sealed partial class CostDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_completions_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferenceCompletionsCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_prompt_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferencePromptCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDetails" /> class.
        /// </summary>
        /// <param name="upstreamInferenceCompletionsCost"></param>
        /// <param name="upstreamInferencePromptCost"></param>
        /// <param name="upstreamInferenceCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDetails(
            double upstreamInferenceCompletionsCost,
            double upstreamInferencePromptCost,
            double? upstreamInferenceCost)
        {
            this.UpstreamInferenceCompletionsCost = upstreamInferenceCompletionsCost;
            this.UpstreamInferenceCost = upstreamInferenceCost;
            this.UpstreamInferencePromptCost = upstreamInferencePromptCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDetails" /> class.
        /// </summary>
        public CostDetails()
        {
        }

    }
}