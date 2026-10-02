
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage statistics<br/>
    /// Example: {"completion_tokens":15,"completion_tokens_details":{"reasoning_tokens":5},"cost":0.0012,"cost_details":{"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008},"is_byok":false,"prompt_tokens":10,"prompt_tokens_details":{"cached_tokens":2},"server_tool_use_details":{"tool_calls_executed":2,"tool_calls_requested":2},"total_tokens":25}
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
        /// Detailed completion token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        public global::OpenRouter.ChatUsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Cost of the completion
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
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Detailed prompt token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::OpenRouter.ChatUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Usage for server-side tool execution (e.g., web search)<br/>
        /// Example: {"tool_calls_executed":2,"tool_calls_requested":2,"web_search_requests":2}
        /// </summary>
        /// <example>{"tool_calls_executed":2,"tool_calls_requested":2,"web_search_requests":2}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use_details")]
        public global::OpenRouter.ServerToolUseDetails? ServerToolUseDetails { get; set; }

        /// <summary>
        /// Total number of tokens
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
        /// <param name="cost">
        /// Cost of the completion
        /// </param>
        /// <param name="costDetails">
        /// Breakdown of upstream inference costs<br/>
        /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
        /// <param name="promptTokensDetails">
        /// Detailed prompt token usage
        /// </param>
        /// <param name="serverToolUseDetails">
        /// Usage for server-side tool execution (e.g., web search)<br/>
        /// Example: {"tool_calls_executed":2,"tool_calls_requested":2,"web_search_requests":2}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            global::OpenRouter.ChatUsageCompletionTokensDetails? completionTokensDetails,
            double? cost,
            global::OpenRouter.CostDetails? costDetails,
            bool? isByok,
            global::OpenRouter.ChatUsagePromptTokensDetails? promptTokensDetails,
            global::OpenRouter.ServerToolUseDetails? serverToolUseDetails)
        {
            this.CompletionTokens = completionTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.IsByok = isByok;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.ServerToolUseDetails = serverToolUseDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsage" /> class.
        /// </summary>
        public ChatUsage()
        {
        }

    }
}