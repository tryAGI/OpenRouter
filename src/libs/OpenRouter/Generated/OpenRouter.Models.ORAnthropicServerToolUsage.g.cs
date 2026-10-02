
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}
    /// </summary>
    public sealed partial class ORAnthropicServerToolUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls_executed")]
        public int? ToolCallsExecuted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls_requested")]
        public int? ToolCallsRequested { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_fetch_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebFetchRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebSearchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicServerToolUsage" /> class.
        /// </summary>
        /// <param name="webFetchRequests"></param>
        /// <param name="webSearchRequests"></param>
        /// <param name="toolCallsExecuted"></param>
        /// <param name="toolCallsRequested"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicServerToolUsage(
            int webFetchRequests,
            int webSearchRequests,
            int? toolCallsExecuted,
            int? toolCallsRequested)
        {
            this.ToolCallsExecuted = toolCallsExecuted;
            this.ToolCallsRequested = toolCallsRequested;
            this.WebFetchRequests = webFetchRequests;
            this.WebSearchRequests = webSearchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicServerToolUsage" /> class.
        /// </summary>
        public ORAnthropicServerToolUsage()
        {
        }

    }
}