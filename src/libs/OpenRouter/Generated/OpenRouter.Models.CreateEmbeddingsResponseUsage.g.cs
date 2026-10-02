
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage statistics<br/>
    /// Example: {"prompt_tokens":8,"total_tokens":8}
    /// </summary>
    public sealed partial class CreateEmbeddingsResponseUsage
    {
        /// <summary>
        /// Cost of the request in credits<br/>
        /// Example: 0.0001F
        /// </summary>
        /// <example>0.0001F</example>
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
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Number of tokens in the input<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Per-modality token breakdown. Only present when the input contains 2+ modalities (e.g. text + image) and the upstream provider returns modality-level usage data. Only non-zero modality counts are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::OpenRouter.CreateEmbeddingsResponseUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens used<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the input<br/>
        /// Example: 8
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used<br/>
        /// Example: 8
        /// </param>
        /// <param name="cost">
        /// Cost of the request in credits<br/>
        /// Example: 0.0001F
        /// </param>
        /// <param name="costDetails">
        /// Breakdown of upstream inference costs<br/>
        /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
        /// <param name="promptTokensDetails">
        /// Per-modality token breakdown. Only present when the input contains 2+ modalities (e.g. text + image) and the upstream provider returns modality-level usage data. Only non-zero modality counts are included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsResponseUsage(
            int promptTokens,
            int totalTokens,
            double? cost,
            global::OpenRouter.CostDetails? costDetails,
            bool? isByok,
            global::OpenRouter.CreateEmbeddingsResponseUsagePromptTokensDetails? promptTokensDetails)
        {
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.IsByok = isByok;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsResponseUsage" /> class.
        /// </summary>
        public CreateEmbeddingsResponseUsage()
        {
        }

    }
}