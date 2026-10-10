
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Router-owned deferred discovery result containing original selected tool definitions.<br/>
    /// Example: {"content":{"matches":[]},"tool_use_id":"search","type":"openrouter_tool_search_result"}
    /// </summary>
    public sealed partial class ORAnthropicToolSearchResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicToolSearchResultTypeJsonConverter))]
        public global::OpenRouter.ORAnthropicToolSearchResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicToolSearchResult" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicToolSearchResult(
            object content,
            string toolUseId,
            global::OpenRouter.ORAnthropicToolSearchResultType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicToolSearchResult" /> class.
        /// </summary>
        public ORAnthropicToolSearchResult()
        {
        }

    }
}