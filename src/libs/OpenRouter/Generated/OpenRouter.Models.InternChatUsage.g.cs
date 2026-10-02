
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage for the run as the daemon reported it, on the final chunk before `[DONE]`. `null` when the daemon reported none, and always `null` after `tool_calls` because the turn is not over.<br/>
    /// Example: {"completion_tokens":12,"prompt_tokens":40,"total_tokens":52}
    /// </summary>
    public sealed partial class InternChatUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// The cost of the run in USD, when the daemon reported one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Prompt tokens served from cache, when the daemon reported them.<br/>
        /// Example: {"cached_tokens":1024}
        /// </summary>
        /// <example>{"cached_tokens":1024}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::OpenRouter.InternChatPromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="InternChatUsage" /> class.
        /// </summary>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cost">
        /// The cost of the run in USD, when the daemon reported one.
        /// </param>
        /// <param name="promptTokensDetails">
        /// Prompt tokens served from cache, when the daemon reported them.<br/>
        /// Example: {"cached_tokens":1024}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            double? cost,
            global::OpenRouter.InternChatPromptTokensDetails? promptTokensDetails)
        {
            this.CompletionTokens = completionTokens;
            this.Cost = cost;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatUsage" /> class.
        /// </summary>
        public InternChatUsage()
        {
        }

    }
}