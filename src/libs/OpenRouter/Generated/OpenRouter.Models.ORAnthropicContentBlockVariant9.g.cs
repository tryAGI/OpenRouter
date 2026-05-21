
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text_editor_code_execution_tool_result variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant9
    {
        /// <summary>
        /// Discriminator value: text_editor_code_execution_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant9TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicTextEditorCodeExecutionContent Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant9" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Discriminator value: text_editor_code_execution_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant9(
            global::OpenRouter.AnthropicTextEditorCodeExecutionContent content,
            string toolUseId,
            global::OpenRouter.ORAnthropicContentBlockVariant9Type type)
        {
            this.Type = type;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant9" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant9()
        {
        }

    }
}