
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:web_search server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant21
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputWebSearchServerToolItemType Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant21" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="action">
        /// The search action performed, matching OpenAI web_search_call.action shape. Includes the query the model issued and optional source URLs returned by the search provider.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant21(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputWebSearchServerToolItemType type,
            global::OpenRouter.OutputWebSearchServerToolItemAction? action,
            string? id)
        {
            this.Type = type;
            this.Action = action;
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant21" /> class.
        /// </summary>
        public OutputItemsVariant21()
        {
        }

    }
}