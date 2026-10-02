
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":{"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"},"tool_use_id":"srvtoolu_01abc","type":"tool_search_tool_result"}
    /// </summary>
    public sealed partial class AnthropicToolSearchToolResult
    {
        /// <summary>
        /// Example: {"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </summary>
        /// <example>{"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicToolSearchContent Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchToolResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicToolSearchToolResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchToolResult" /> class.
        /// </summary>
        /// <param name="content">
        /// Example: {"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicToolSearchToolResult(
            global::OpenRouter.AnthropicToolSearchContent content,
            string toolUseId,
            global::OpenRouter.AnthropicToolSearchToolResultType type)
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchToolResult" /> class.
        /// </summary>
        public AnthropicToolSearchToolResult()
        {
        }

    }
}