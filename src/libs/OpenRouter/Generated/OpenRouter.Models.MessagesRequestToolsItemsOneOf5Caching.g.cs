
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
    /// </summary>
    public sealed partial class MessagesRequestToolsItemsOneOf5Caching
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlTtlJsonConverter))]
        public global::OpenRouter.AnthropicCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf5CachingTypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf5CachingType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf5Caching" /> class.
        /// </summary>
        /// <param name="ttl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItemsOneOf5Caching(
            global::OpenRouter.AnthropicCacheControlTtl? ttl,
            global::OpenRouter.MessagesRequestToolsItemsOneOf5CachingType type)
        {
            this.Ttl = ttl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf5Caching" /> class.
        /// </summary>
        public MessagesRequestToolsItemsOneOf5Caching()
        {
        }

    }
}