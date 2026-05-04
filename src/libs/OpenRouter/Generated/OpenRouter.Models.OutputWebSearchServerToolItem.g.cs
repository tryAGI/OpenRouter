
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:web_search server tool output item
    /// </summary>
    public sealed partial class OutputWebSearchServerToolItem
    {
        /// <summary>
        /// The search action performed, matching OpenAI web_search_call.action shape. Includes the query the model issued and optional source URLs returned by the search provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::OpenRouter.OutputWebSearchServerToolItemAction? Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputWebSearchServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="action">
        /// The search action performed, matching OpenAI web_search_call.action shape. Includes the query the model issued and optional source URLs returned by the search provider.
        /// </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputWebSearchServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputWebSearchServerToolItemAction? action,
            string? id,
            global::OpenRouter.OutputWebSearchServerToolItemType type)
        {
            this.Action = action;
            this.Id = id;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchServerToolItem" /> class.
        /// </summary>
        public OutputWebSearchServerToolItem()
        {
        }
    }
}