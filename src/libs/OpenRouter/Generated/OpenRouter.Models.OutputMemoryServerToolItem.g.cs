
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:memory server tool output item
    /// </summary>
    public sealed partial class OutputMemoryServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMemoryServerToolItemActionJsonConverter))]
        public global::OpenRouter.OutputMemoryServerToolItemAction? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMemoryServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputMemoryServerToolItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMemoryServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputMemoryServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputMemoryServerToolItemAction? action,
            string? id,
            string? key,
            global::OpenRouter.OutputMemoryServerToolItemType type,
            object? value)
        {
            this.Action = action;
            this.Id = id;
            this.Key = key;
            this.Status = status;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMemoryServerToolItem" /> class.
        /// </summary>
        public OutputMemoryServerToolItem()
        {
        }
    }
}