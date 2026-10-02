
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Loads a previously deferred tool (declared in `tools` with `defer_loading: true`) mid-conversation without invalidating the prompt cache. Only valid in `role: "system"` messages. Not supported on Claude Sonnet 5 or models older than Claude Opus 4.8.<br/>
    /// Example: {"tool":{"name":"get_forecast","type":"tool_reference"},"type":"tool_addition"}
    /// </summary>
    public sealed partial class MessagesToolAdditionBlock
    {
        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
        /// <example>{"type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesToolAdditionBlockToolVariant1, global::OpenRouter.MessagesToolAdditionBlockToolVariant2, global::OpenRouter.MessagesToolAdditionBlockToolVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.MessagesToolAdditionBlockToolVariant1, global::OpenRouter.MessagesToolAdditionBlockToolVariant2, global::OpenRouter.MessagesToolAdditionBlockToolVariant3> Tool { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolAdditionBlockTypeJsonConverter))]
        public global::OpenRouter.MessagesToolAdditionBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolAdditionBlock" /> class.
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolAdditionBlock(
            global::OpenRouter.OneOf<global::OpenRouter.MessagesToolAdditionBlockToolVariant1, global::OpenRouter.MessagesToolAdditionBlockToolVariant2, global::OpenRouter.MessagesToolAdditionBlockToolVariant3> tool,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.MessagesToolAdditionBlockType type)
        {
            this.CacheControl = cacheControl;
            this.Tool = tool;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolAdditionBlock" /> class.
        /// </summary>
        public MessagesToolAdditionBlock()
        {
        }

    }
}