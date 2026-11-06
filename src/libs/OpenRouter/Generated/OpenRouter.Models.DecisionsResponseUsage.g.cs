
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsResponseUsage
    {
        /// <summary>
        /// What OpenRouter charges for the request, in credits. On a BYOK request this is the OpenRouter fee only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Breakdown of upstream inference costs<br/>
        /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
        /// </summary>
        /// <example>{"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        public global::OpenRouter.CostDetails? CostDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Of `input_tokens`, those the provider served from its prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        public global::OpenRouter.DecisionsUsageInputTokensDetails? InputTokensDetails { get; set; }

        /// <summary>
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsResponseUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cost">
        /// What OpenRouter charges for the request, in credits. On a BYOK request this is the OpenRouter fee only.
        /// </param>
        /// <param name="costDetails">
        /// Breakdown of upstream inference costs<br/>
        /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
        /// </param>
        /// <param name="inputTokensDetails">
        /// Of `input_tokens`, those the provider served from its prompt cache.
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsResponseUsage(
            int inputTokens,
            int outputTokens,
            double? cost,
            global::OpenRouter.CostDetails? costDetails,
            global::OpenRouter.DecisionsUsageInputTokensDetails? inputTokensDetails,
            bool? isByok)
        {
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails;
            this.IsByok = isByok;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsResponseUsage" /> class.
        /// </summary>
        public DecisionsResponseUsage()
        {
        }

    }
}