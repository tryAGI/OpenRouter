
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:tool_search server tool output item
    /// </summary>
    public sealed partial class OutputToolSearchServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputToolSearchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputToolSearchServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="query"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputToolSearchServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? id,
            string? query,
            global::OpenRouter.OutputToolSearchServerToolItemType type)
        {
            this.Id = id;
            this.Query = query;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchServerToolItem" /> class.
        /// </summary>
        public OutputToolSearchServerToolItem()
        {
        }
    }
}