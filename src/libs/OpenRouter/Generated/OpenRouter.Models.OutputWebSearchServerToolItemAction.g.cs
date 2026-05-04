
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The search action performed, matching OpenAI web_search_call.action shape. Includes the query the model issued and optional source URLs returned by the search provider.
    /// </summary>
    public sealed partial class OutputWebSearchServerToolItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems>? Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemActionTypeJsonConverter))]
        public global::OpenRouter.OutputWebSearchServerToolItemActionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchServerToolItemAction" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sources"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputWebSearchServerToolItemAction(
            string query,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems>? sources,
            global::OpenRouter.OutputWebSearchServerToolItemActionType type)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Sources = sources;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchServerToolItemAction" /> class.
        /// </summary>
        public OutputWebSearchServerToolItemAction()
        {
        }
    }
}