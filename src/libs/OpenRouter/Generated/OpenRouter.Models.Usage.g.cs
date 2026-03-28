
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage information for the response
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAiResponsesUsageInputTokensDetails InputTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAiResponsesUsageOutputTokensDetails OutputTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// Cost of the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        public global::OpenRouter.UsageCostDetails? CostDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="inputTokensDetails"></param>
        /// <param name="outputTokens"></param>
        /// <param name="outputTokensDetails"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cost">
        /// Cost of the completion
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
        /// <param name="costDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            double inputTokens,
            global::OpenRouter.OpenAiResponsesUsageInputTokensDetails inputTokensDetails,
            double outputTokens,
            global::OpenRouter.OpenAiResponsesUsageOutputTokensDetails outputTokensDetails,
            double totalTokens,
            double? cost,
            bool? isByok,
            global::OpenRouter.UsageCostDetails? costDetails)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(outputTokensDetails));
            this.TotalTokens = totalTokens;
            this.Cost = cost;
            this.IsByok = isByok;
            this.CostDetails = costDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}