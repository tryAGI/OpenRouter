
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:file_search server tool output item
    /// </summary>
    public sealed partial class OutputFileSearchServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputFileSearchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputFileSearchServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFileSearchServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="queries"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFileSearchServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? id,
            global::System.Collections.Generic.IList<string>? queries,
            global::OpenRouter.OutputFileSearchServerToolItemType type)
        {
            this.Id = id;
            this.Queries = queries;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFileSearchServerToolItem" /> class.
        /// </summary>
        public OutputFileSearchServerToolItem()
        {
        }
    }
}