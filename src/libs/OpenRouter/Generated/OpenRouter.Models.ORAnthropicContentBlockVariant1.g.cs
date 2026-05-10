
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// bash_code_execution_tool_result variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant1
    {
        /// <summary>
        /// Discriminator value: bash_code_execution_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant1TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicBashCodeExecutionContent Content { get; set; }

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
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Discriminator value: bash_code_execution_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant1(
            global::OpenRouter.AnthropicBashCodeExecutionContent content,
            string toolUseId,
            global::OpenRouter.ORAnthropicContentBlockVariant1Type type)
        {
            this.Type = type;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant1" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant1()
        {
        }

    }
}