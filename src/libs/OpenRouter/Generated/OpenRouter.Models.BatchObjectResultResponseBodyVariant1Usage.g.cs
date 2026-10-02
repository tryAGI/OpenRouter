
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1Usage
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
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

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
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Usage for server-side tool execution (e.g., web search)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUse? ServerToolUse { get; set; }

        /// <summary>
        /// Usage for server-side tool execution (e.g., web search)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use_details")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUseDetails? ServerToolUseDetails { get; set; }

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
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1Usage" /> class.
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
        /// <param name="promptTokensDetails">
        /// Breakdown of tokens used in the prompt.
        /// </param>
        /// <param name="serverToolUse">
        /// Usage for server-side tool execution (e.g., web search)
        /// </param>
        /// <param name="serverToolUseDetails">
        /// Usage for server-side tool execution (e.g., web search)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1Usage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageCompletionTokensDetails? completionTokensDetails,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1UsagePromptTokensDetails? promptTokensDetails,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUse? serverToolUse,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUseDetails? serverToolUseDetails)
        {
            this.CompletionTokens = completionTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.ServerToolUse = serverToolUse;
            this.ServerToolUseDetails = serverToolUseDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1Usage" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1Usage()
        {
        }

    }
}