
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token and cost usage for the image generation request, when available
    /// </summary>
    public sealed partial class ImageGenerationUsage
    {
        /// <summary>
        /// The tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationUsageCompletionTokensDetails, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationUsageCompletionTokensDetails, object>? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Cost of the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Breakdown of upstream inference costs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        public global::OpenRouter.CostDetails? CostDetails { get; set; }

        /// <summary>
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Iterations { get; set; }

        /// <summary>
        /// Including images, input audio, and tools if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Breakdown of tokens used in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationUsagePromptTokensDetails, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationUsagePromptTokensDetails, object>? PromptTokensDetails { get; set; }

        /// <summary>
        /// Usage for server-side tool execution (e.g., web search)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationUsageServerToolUse, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationUsageServerToolUse, object>? ServerToolUse { get; set; }

        /// <summary>
        /// The service tier used by the upstream provider for this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicSpeedJsonConverter))]
        public global::OpenRouter.AnthropicSpeed? Speed { get; set; }

        /// <summary>
        /// Sum of the above two fields
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
        /// Initializes a new instance of the <see cref="ImageGenerationUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// The tokens generated
        /// </param>
        /// <param name="promptTokens">
        /// Including images, input audio, and tools if any
        /// </param>
        /// <param name="totalTokens">
        /// Sum of the above two fields
        /// </param>
        /// <param name="completionTokensDetails"></param>
        /// <param name="cost">
        /// Cost of the completion
        /// </param>
        /// <param name="costDetails">
        /// Breakdown of upstream inference costs
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
        /// <param name="iterations"></param>
        /// <param name="promptTokensDetails">
        /// Breakdown of tokens used in the prompt.
        /// </param>
        /// <param name="serverToolUse">
        /// Usage for server-side tool execution (e.g., web search)
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used by the upstream provider for this request
        /// </param>
        /// <param name="speed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationUsageCompletionTokensDetails, object>? completionTokensDetails,
            double? cost,
            global::OpenRouter.CostDetails? costDetails,
            bool? isByok,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? iterations,
            global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationUsagePromptTokensDetails, object>? promptTokensDetails,
            global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationUsageServerToolUse, object>? serverToolUse,
            string? serviceTier,
            global::OpenRouter.AnthropicSpeed? speed)
        {
            this.CompletionTokens = completionTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.IsByok = isByok;
            this.Iterations = iterations;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.ServerToolUse = serverToolUse;
            this.ServiceTier = serviceTier;
            this.Speed = speed;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationUsage" /> class.
        /// </summary>
        public ImageGenerationUsage()
        {
        }

    }
}