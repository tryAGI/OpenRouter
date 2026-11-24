
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool search result from a prior assistant turn, returned beside the `server_tool_use` it answers.<br/>
    /// Example: {"content":{"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"},"tool_use_id":"srvtoolu_01abc","type":"tool_search_tool_result"}
    /// </summary>
    public sealed partial class MessagesToolSearchToolResultBlock
    {
        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
        /// <example>{"type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// What a tool search returned: the tools it found, or an error.<br/>
        /// Example: {"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </summary>
        /// <example>{"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolSearchToolResultContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesToolSearchToolResultContent Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolSearchToolResultBlockTypeJsonConverter))]
        public global::OpenRouter.MessagesToolSearchToolResultBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolResultBlock" /> class.
        /// </summary>
        /// <param name="content">
        /// What a tool search returned: the tools it found, or an error.<br/>
        /// Example: {"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </param>
        /// <param name="toolUseId"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolSearchToolResultBlock(
            global::OpenRouter.MessagesToolSearchToolResultContent content,
            string toolUseId,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.MessagesToolSearchToolResultBlockType type)
        {
            this.CacheControl = cacheControl;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolResultBlock" /> class.
        /// </summary>
        public MessagesToolSearchToolResultBlock()
        {
        }

    }
}