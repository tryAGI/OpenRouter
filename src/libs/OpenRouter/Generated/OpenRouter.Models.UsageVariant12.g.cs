
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageVariant12
    {
        /// <summary>
        /// Cost of the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        public global::OpenRouter.UsageVariant1CostDetails? CostDetails { get; set; }

        /// <summary>
        /// Totals across every upstream model call of a deferred-tools run. The native usage fields report only the final call; cost covers every call.<br/>
        /// Example: {"completion_tokens":180,"prompt_tokens":2400,"total_tokens":2580,"turns":2}
        /// </summary>
        /// <example>{"completion_tokens":180,"prompt_tokens":2400,"total_tokens":2580,"turns":2}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred_tools_details")]
        public global::OpenRouter.DeferredToolsDetails? DeferredToolsDetails { get; set; }

        /// <summary>
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Usage for server-side tool execution (e.g., web search)<br/>
        /// Example: {"tool_calls_executed":2,"tool_calls_requested":2,"web_search_requests":2}
        /// </summary>
        /// <example>{"tool_calls_executed":2,"tool_calls_requested":2,"web_search_requests":2}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use_details")]
        public global::OpenRouter.ServerToolUseDetails? ServerToolUseDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVariant12" /> class.
        /// </summary>
        /// <param name="cost">
        /// Cost of the completion
        /// </param>
        /// <param name="costDetails"></param>
        /// <param name="deferredToolsDetails">
        /// Totals across every upstream model call of a deferred-tools run. The native usage fields report only the final call; cost covers every call.<br/>
        /// Example: {"completion_tokens":180,"prompt_tokens":2400,"total_tokens":2580,"turns":2}
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
        /// <param name="serverToolUseDetails">
        /// Usage for server-side tool execution (e.g., web search)<br/>
        /// Example: {"tool_calls_executed":2,"tool_calls_requested":2,"web_search_requests":2}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageVariant12(
            double? cost,
            global::OpenRouter.UsageVariant1CostDetails? costDetails,
            global::OpenRouter.DeferredToolsDetails? deferredToolsDetails,
            bool? isByok,
            global::OpenRouter.ServerToolUseDetails? serverToolUseDetails)
        {
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.DeferredToolsDetails = deferredToolsDetails;
            this.IsByok = isByok;
            this.ServerToolUseDetails = serverToolUseDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVariant12" /> class.
        /// </summary>
        public UsageVariant12()
        {
        }

    }
}