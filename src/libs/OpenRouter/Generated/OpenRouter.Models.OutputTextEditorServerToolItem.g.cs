
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:text_editor server tool output item
    /// </summary>
    public sealed partial class OutputTextEditorServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemCommandJsonConverter))]
        public global::OpenRouter.OutputTextEditorServerToolItemCommand? Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filePath")]
        public string? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputTextEditorServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextEditorServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="command"></param>
        /// <param name="filePath"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTextEditorServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputTextEditorServerToolItemCommand? command,
            string? filePath,
            string? id,
            global::OpenRouter.OutputTextEditorServerToolItemType type)
        {
            this.Command = command;
            this.FilePath = filePath;
            this.Id = id;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextEditorServerToolItem" /> class.
        /// </summary>
        public OutputTextEditorServerToolItem()
        {
        }
    }
}