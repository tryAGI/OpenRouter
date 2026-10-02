
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Breakdown of upstream inference costs<br/>
    /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
    /// </summary>
    public sealed partial class CostDetails
    {
        /// <summary>
        /// Metered server-tool execution cost (for example, shell sandbox time) billed for this request, in USD. Matches the billed checkpoint and settlement amounts exactly. 0 when a metered server tool ran but settled at zero dollars; absent when no metered server tool ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_cost")]
        public double? ServerToolCost { get; set; }

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
        /// <param name="serverToolCost">
        /// Metered server-tool execution cost (for example, shell sandbox time) billed for this request, in USD. Matches the billed checkpoint and settlement amounts exactly. 0 when a metered server tool ran but settled at zero dollars; absent when no metered server tool ran.
        /// </param>
        /// <param name="upstreamInferenceCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDetails(
            double upstreamInferenceCompletionsCost,
            double upstreamInferencePromptCost,
            double? serverToolCost,
            double? upstreamInferenceCost)
        {
            this.ServerToolCost = serverToolCost;
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