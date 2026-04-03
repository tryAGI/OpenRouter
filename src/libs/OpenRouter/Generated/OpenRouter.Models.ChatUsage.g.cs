
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage statistics
    /// </summary>
    public sealed partial class ChatUsage
    {
        /// <summary>
        /// Number of tokens in the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Total number of tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Detailed completion token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatUsageCompletionTokensDetails, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ChatUsageCompletionTokensDetails, object>? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Detailed prompt token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatUsagePromptTokensDetails, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ChatUsagePromptTokensDetails, object>? PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of tokens in the completion
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens
        /// </param>
        /// <param name="completionTokensDetails">
        /// Detailed completion token usage
        /// </param>
        /// <param name="promptTokensDetails">
        /// Detailed prompt token usage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            global::OpenRouter.OneOf<global::OpenRouter.ChatUsageCompletionTokensDetails, object>? completionTokensDetails,
            global::OpenRouter.OneOf<global::OpenRouter.ChatUsagePromptTokensDetails, object>? promptTokensDetails)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.PromptTokensDetails = promptTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsage" /> class.
        /// </summary>
        public ChatUsage()
        {
        }
    }
}