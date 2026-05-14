
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// code_execution_tool_result variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant3
    {
        /// <summary>
        /// Discriminator value: code_execution_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant3TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicCodeExecutionContent Content { get; set; }

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
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant3" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Discriminator value: code_execution_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant3(
            global::OpenRouter.AnthropicCodeExecutionContent content,
            string toolUseId,
            global::OpenRouter.ORAnthropicContentBlockVariant3Type type)
        {
            this.Type = type;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant3" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant3()
        {
        }

    }
}