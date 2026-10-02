
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesDeltaEventUsage
    {
        /// <summary>
        /// Example: {"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":100}
        /// </summary>
        /// <example>{"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":100}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::OpenRouter.AnthropicCacheCreation? CacheCreation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Iterations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Example: {"thinking_tokens":0}
        /// </summary>
        /// <example>{"thinking_tokens":0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::OpenRouter.AnthropicOutputTokensDetails? OutputTokensDetails { get; set; }

        /// <summary>
        /// Example: {"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}
        /// </summary>
        /// <example>{"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::OpenRouter.ORAnthropicServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesDeltaEventUsage" /> class.
        /// </summary>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreation">
        /// Example: {"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":100}
        /// </param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="iterations"></param>
        /// <param name="outputTokensDetails">
        /// Example: {"thinking_tokens":0}
        /// </param>
        /// <param name="serverToolUse">
        /// Example: {"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesDeltaEventUsage(
            int outputTokens,
            global::OpenRouter.AnthropicCacheCreation? cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            int? inputTokens,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? iterations,
            global::OpenRouter.AnthropicOutputTokensDetails? outputTokensDetails,
            global::OpenRouter.ORAnthropicServerToolUsage? serverToolUse)
        {
            this.CacheCreation = cacheCreation;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InputTokens = inputTokens;
            this.Iterations = iterations;
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails;
            this.ServerToolUse = serverToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesDeltaEventUsage" /> class.
        /// </summary>
        public MessagesDeltaEventUsage()
        {
        }

    }
}