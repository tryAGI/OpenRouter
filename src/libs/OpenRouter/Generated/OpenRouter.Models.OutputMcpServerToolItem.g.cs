
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:mcp server tool output item
    /// </summary>
    public sealed partial class OutputMcpServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverLabel")]
        public string? ServerLabel { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMcpServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputMcpServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMcpServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="serverLabel"></param>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputMcpServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? id,
            string? serverLabel,
            string? toolName,
            global::OpenRouter.OutputMcpServerToolItemType type)
        {
            this.Id = id;
            this.ServerLabel = serverLabel;
            this.Status = status;
            this.ToolName = toolName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMcpServerToolItem" /> class.
        /// </summary>
        public OutputMcpServerToolItem()
        {
        }
    }
}