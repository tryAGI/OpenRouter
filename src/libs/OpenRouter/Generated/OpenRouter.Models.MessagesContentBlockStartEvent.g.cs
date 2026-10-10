
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event sent when a new content block starts<br/>
    /// Example: {"content_block":{"citations":[],"text":"","type":"text"},"index":0,"type":"content_block_start"}
    /// </summary>
    public sealed partial class MessagesContentBlockStartEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_block")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.AnthropicTextBlock, global::OpenRouter.AnthropicToolUseBlock, global::OpenRouter.AnthropicThinkingBlock, global::OpenRouter.AnthropicRedactedThinkingBlock, global::OpenRouter.ORAnthropicServerToolUseBlock, global::OpenRouter.AnthropicWebSearchToolResult, global::OpenRouter.AnthropicWebFetchToolResult, global::OpenRouter.AnthropicCodeExecutionToolResult, global::OpenRouter.AnthropicBashCodeExecutionToolResult, global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult, global::OpenRouter.AnthropicToolSearchToolResult, global::OpenRouter.AnthropicContainerUpload, global::OpenRouter.AnthropicCompactionBlock, global::OpenRouter.AnthropicAdvisorToolResult, global::OpenRouter.ORAnthropicShellToolResult, global::OpenRouter.ORAnthropicBashToolResult, global::OpenRouter.ORAnthropicToolSearchResult, global::OpenRouter.MessagesContentBlockStartEventContentBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.AnthropicTextBlock, global::OpenRouter.AnthropicToolUseBlock, global::OpenRouter.AnthropicThinkingBlock, global::OpenRouter.AnthropicRedactedThinkingBlock, global::OpenRouter.ORAnthropicServerToolUseBlock, global::OpenRouter.AnthropicWebSearchToolResult, global::OpenRouter.AnthropicWebFetchToolResult, global::OpenRouter.AnthropicCodeExecutionToolResult, global::OpenRouter.AnthropicBashCodeExecutionToolResult, global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult, global::OpenRouter.AnthropicToolSearchToolResult, global::OpenRouter.AnthropicContainerUpload, global::OpenRouter.AnthropicCompactionBlock, global::OpenRouter.AnthropicAdvisorToolResult, global::OpenRouter.ORAnthropicShellToolResult, global::OpenRouter.ORAnthropicBashToolResult, global::OpenRouter.ORAnthropicToolSearchResult, global::OpenRouter.MessagesContentBlockStartEventContentBlock> ContentBlock { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockStartEventTypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockStartEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockStartEvent" /> class.
        /// </summary>
        /// <param name="contentBlock"></param>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockStartEvent(
            global::OpenRouter.AnyOf<global::OpenRouter.AnthropicTextBlock, global::OpenRouter.AnthropicToolUseBlock, global::OpenRouter.AnthropicThinkingBlock, global::OpenRouter.AnthropicRedactedThinkingBlock, global::OpenRouter.ORAnthropicServerToolUseBlock, global::OpenRouter.AnthropicWebSearchToolResult, global::OpenRouter.AnthropicWebFetchToolResult, global::OpenRouter.AnthropicCodeExecutionToolResult, global::OpenRouter.AnthropicBashCodeExecutionToolResult, global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult, global::OpenRouter.AnthropicToolSearchToolResult, global::OpenRouter.AnthropicContainerUpload, global::OpenRouter.AnthropicCompactionBlock, global::OpenRouter.AnthropicAdvisorToolResult, global::OpenRouter.ORAnthropicShellToolResult, global::OpenRouter.ORAnthropicBashToolResult, global::OpenRouter.ORAnthropicToolSearchResult, global::OpenRouter.MessagesContentBlockStartEventContentBlock> contentBlock,
            int index,
            global::OpenRouter.MessagesContentBlockStartEventType type)
        {
            this.ContentBlock = contentBlock;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockStartEvent" /> class.
        /// </summary>
        public MessagesContentBlockStartEvent()
        {
        }

    }
}