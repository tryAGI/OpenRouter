
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":{"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"},"tool_use_id":"srvtoolu_01abc","type":"text_editor_code_execution_tool_result"}
    /// </summary>
    public sealed partial class AnthropicTextEditorCodeExecutionToolResult
    {
        /// <summary>
        /// Example: {"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"}
        /// </summary>
        /// <example>{"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"}</example>
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionToolResult" /> class.
        /// </summary>
        /// <param name="content">
        /// Example: {"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"}
        /// </param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextEditorCodeExecutionToolResult(
            global::OpenRouter.AnthropicTextEditorCodeExecutionContent content,
            string toolUseId,
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultType type)
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionToolResult" /> class.
        /// </summary>
        public AnthropicTextEditorCodeExecutionToolResult()
        {
        }

    }
}