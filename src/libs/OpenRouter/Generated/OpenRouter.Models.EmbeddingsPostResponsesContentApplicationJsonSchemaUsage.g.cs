
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage statistics
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaUsage
    {
        /// <summary>
        /// Cost of the request in credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Breakdown of upstream inference costs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsageCostDetails, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsageCostDetails, object>? CostDetails { get; set; }

        /// <summary>
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Number of tokens in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Per-modality token breakdown. Only present when the input contains 2+ modalities (e.g. text + image) and the upstream provider returns modality-level usage data. Only non-zero modality counts are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the input
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used
        /// </param>
        /// <param name="cost">
        /// Cost of the request in credits
        /// </param>
        /// <param name="costDetails">
        /// Breakdown of upstream inference costs
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
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsage(
            int promptTokens,
            int totalTokens,
            double? cost,
            global::OpenRouter.OneOf<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsageCostDetails, object>? costDetails,
            bool? isByok,
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails? promptTokensDetails)
        {
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.IsByok = isByok;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsage()
        {
        }

    }
}