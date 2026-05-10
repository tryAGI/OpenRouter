
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text_editor_code_execution_view_result variant
    /// </summary>
    public sealed partial class AnthropicTextEditorCodeExecutionContentVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lines")]
        public int? TotalLines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant4" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="fileType"></param>
        /// <param name="type"></param>
        /// <param name="numLines"></param>
        /// <param name="startLine"></param>
        /// <param name="totalLines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextEditorCodeExecutionContentVariant4(
            string content,
            global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType fileType,
            global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType type,
            int? numLines,
            int? startLine,
            int? totalLines)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FileType = fileType;
            this.NumLines = numLines;
            this.StartLine = startLine;
            this.TotalLines = totalLines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant4" /> class.
        /// </summary>
        public AnthropicTextEditorCodeExecutionContentVariant4()
        {
        }

    }
}