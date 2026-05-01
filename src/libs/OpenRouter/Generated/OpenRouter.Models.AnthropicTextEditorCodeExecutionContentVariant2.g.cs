
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text_editor_code_execution_str_replace_result variant
    /// </summary>
    public sealed partial class AnthropicTextEditorCodeExecutionContentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionStrReplaceResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<string>? Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_lines")]
        public int? NewLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_start")]
        public int? NewStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_lines")]
        public int? OldLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_start")]
        public int? OldStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="lines"></param>
        /// <param name="newLines"></param>
        /// <param name="newStart"></param>
        /// <param name="oldLines"></param>
        /// <param name="oldStart"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextEditorCodeExecutionContentVariant2(
            global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType type,
            global::System.Collections.Generic.IList<string>? lines,
            int? newLines,
            int? newStart,
            int? oldLines,
            int? oldStart)
        {
            this.Type = type;
            this.Lines = lines;
            this.NewLines = newLines;
            this.NewStart = newStart;
            this.OldLines = oldLines;
            this.OldStart = oldStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant2" /> class.
        /// </summary>
        public AnthropicTextEditorCodeExecutionContentVariant2()
        {
        }
    }
}