
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The tools a tool search found, by name, in match order.<br/>
    /// Example: {"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
    /// </summary>
    public sealed partial class MessagesToolSearchToolSearchResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.MessagesToolSearchToolReference> ToolReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolSearchToolSearchResultTypeJsonConverter))]
        public global::OpenRouter.MessagesToolSearchToolSearchResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolSearchResult" /> class.
        /// </summary>
        /// <param name="toolReferences"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolSearchToolSearchResult(
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesToolSearchToolReference> toolReferences,
            global::OpenRouter.MessagesToolSearchToolSearchResultType type)
        {
            this.ToolReferences = toolReferences ?? throw new global::System.ArgumentNullException(nameof(toolReferences));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolSearchResult" /> class.
        /// </summary>
        public MessagesToolSearchToolSearchResult()
        {
        }

    }
}