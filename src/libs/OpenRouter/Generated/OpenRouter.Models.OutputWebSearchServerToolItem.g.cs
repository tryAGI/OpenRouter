
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:web_search server tool output item<br/>
    /// Example: {"action":{"query":"latest AI news","type":"search"},"id":"ws_tmp_abc123","status":"completed","type":"openrouter:web_search"}
    /// </summary>
    public sealed partial class OutputWebSearchServerToolItem
    {
        /// <summary>
        /// The search action performed, matching OpenAI web_search_call.action shape. Includes the query the model issued and optional source URLs returned by the search provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::OpenRouter.OutputWebSearchServerToolItemAction? Action { get; set; }

        /// <summary>
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </summary>
        /// <example>Tool execution failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FailableToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FailableToolCallStatus Status { get; set; }

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
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="action">
        /// The search action performed, matching OpenAI web_search_call.action shape. Includes the query the model issued and optional source URLs returned by the search provider.
        /// </param>
        /// <param name="error">
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputWebSearchServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            global::OpenRouter.OutputWebSearchServerToolItemAction? action,
            string? error,
            string? id,
            global::OpenRouter.OutputWebSearchServerToolItemType type)
        {
            this.Action = action;
            this.Error = error;
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