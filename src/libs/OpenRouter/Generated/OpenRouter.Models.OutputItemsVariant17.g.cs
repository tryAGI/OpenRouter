
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// openrouter:text_editor variant
    /// </summary>
    public sealed partial class OutputItemsVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputTextEditorServerToolItemType Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant17" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="command"></param>
        /// <param name="filePath"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant17(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputTextEditorServerToolItemType type,
            global::OpenRouter.OutputTextEditorServerToolItemCommand? command,
            string? filePath,
            string? id)
        {
            this.Type = type;
            this.Command = command;
            this.FilePath = filePath;
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant17" /> class.
        /// </summary>
        public OutputItemsVariant17()
        {
        }
    }
}