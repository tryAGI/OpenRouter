
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageVariant1CostDetails
    {
        /// <summary>
        /// Metered server-tool execution cost (for example, shell sandbox time) billed for this request, in USD. Matches the billed checkpoint and settlement amounts exactly. 0 when a metered server tool ran but settled at zero dollars; absent when no metered server tool ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_cost")]
        public double? ServerToolCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_input_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferenceInputCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_output_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferenceOutputCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVariant1CostDetails" /> class.
        /// </summary>
        /// <param name="upstreamInferenceInputCost"></param>
        /// <param name="upstreamInferenceOutputCost"></param>
        /// <param name="serverToolCost">
        /// Metered server-tool execution cost (for example, shell sandbox time) billed for this request, in USD. Matches the billed checkpoint and settlement amounts exactly. 0 when a metered server tool ran but settled at zero dollars; absent when no metered server tool ran.
        /// </param>
        /// <param name="upstreamInferenceCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageVariant1CostDetails(
            double upstreamInferenceInputCost,
            double upstreamInferenceOutputCost,
            double? serverToolCost,
            double? upstreamInferenceCost)
        {
            this.ServerToolCost = serverToolCost;
            this.UpstreamInferenceCost = upstreamInferenceCost;
            this.UpstreamInferenceInputCost = upstreamInferenceInputCost;
            this.UpstreamInferenceOutputCost = upstreamInferenceOutputCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVariant1CostDetails" /> class.
        /// </summary>
        public UsageVariant1CostDetails()
        {
        }

    }
}