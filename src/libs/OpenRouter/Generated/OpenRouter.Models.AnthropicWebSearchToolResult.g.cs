
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"caller":{"type":"direct"},"content":[],"tool_use_id":"srvtoolu_01abc","type":"web_search_tool_result"}
    /// </summary>
    public sealed partial class AnthropicWebSearchToolResult
    {
        /// <summary>
        /// Example: {"type":"direct"}
        /// </summary>
        /// <example>{"type":"direct"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCallerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicCaller Caller { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError> Content { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicWebSearchToolResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicWebSearchToolResult" /> class.
        /// </summary>
        /// <param name="caller">
        /// Example: {"type":"direct"}
        /// </param>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicWebSearchToolResult(
            global::OpenRouter.AnthropicCaller caller,
            global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError> content,
            string toolUseId,
            global::OpenRouter.AnthropicWebSearchToolResultType type)
        {
            this.Caller = caller;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicWebSearchToolResult" /> class.
        /// </summary>
        public AnthropicWebSearchToolResult()
        {
        }

    }
}