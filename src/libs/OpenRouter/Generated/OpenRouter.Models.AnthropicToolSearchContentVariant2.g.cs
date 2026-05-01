
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// tool_search_tool_search_result variant
    /// </summary>
    public sealed partial class AnthropicToolSearchContentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicToolSearchResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference> ToolReferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchContentVariant2" /> class.
        /// </summary>
        /// <param name="toolReferences"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicToolSearchContentVariant2(
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference> toolReferences,
            global::OpenRouter.AnthropicToolSearchResultType type)
        {
            this.Type = type;
            this.ToolReferences = toolReferences ?? throw new global::System.ArgumentNullException(nameof(toolReferences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchContentVariant2" /> class.
        /// </summary>
        public AnthropicToolSearchContentVariant2()
        {
        }
    }
}