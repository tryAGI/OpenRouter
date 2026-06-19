
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Usage for server-side tool execution (e.g., web search)
    /// </summary>
    public sealed partial class ChatUsageServerToolUseDetails
    {
        /// <summary>
        /// Number of OpenRouter server tool calls that executed and produced a result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls_executed")]
        public int? ToolCallsExecuted { get; set; }

        /// <summary>
        /// Total number of OpenRouter server-orchestrated tool calls the model requested, across all tool types. Provider-native tools (e.g. native web search) are not counted here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls_requested")]
        public int? ToolCallsRequested { get; set; }

        /// <summary>
        /// Number of web searches performed by server-side tools. For server-orchestrated tool calls a web search is also counted in tool_calls_requested; provider-native web search may report web_search_requests only. Do not sum the two.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        public int? WebSearchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsageServerToolUseDetails" /> class.
        /// </summary>
        /// <param name="toolCallsExecuted">
        /// Number of OpenRouter server tool calls that executed and produced a result
        /// </param>
        /// <param name="toolCallsRequested">
        /// Total number of OpenRouter server-orchestrated tool calls the model requested, across all tool types. Provider-native tools (e.g. native web search) are not counted here.
        /// </param>
        /// <param name="webSearchRequests">
        /// Number of web searches performed by server-side tools. For server-orchestrated tool calls a web search is also counted in tool_calls_requested; provider-native web search may report web_search_requests only. Do not sum the two.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUsageServerToolUseDetails(
            int? toolCallsExecuted,
            int? toolCallsRequested,
            int? webSearchRequests)
        {
            this.ToolCallsExecuted = toolCallsExecuted;
            this.ToolCallsRequested = toolCallsRequested;
            this.WebSearchRequests = webSearchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsageServerToolUseDetails" /> class.
        /// </summary>
        public ChatUsageServerToolUseDetails()
        {
        }

    }
}